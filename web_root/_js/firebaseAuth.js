// Import the functions you need from the SDKs you need
import { initializeApp } from "https://www.gstatic.com/firebasejs/9.6.1/firebase-app.js";
import { getAuth, getIdToken, reload, getIdTokenResult, onAuthStateChanged, GoogleAuthProvider, signInWithPopup, signOut } from "https://www.gstatic.com/firebasejs/9.6.1/firebase-auth.js"
import { doc, getDoc, updateDoc, getFirestore, setDoc  } from "https://www.gstatic.com/firebasejs/9.6.1/firebase-firestore.js"


// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
    apiKey: "AIzaSyCxDs2c5zvgXmaao6a2JpeSKmXL4OdmIIE",
    authDomain: "dev-validator-test.firebaseapp.com",
    databaseURL: "https://dev-validator-test.firebaseio.com",
    projectId: "dev-validator-test",
    storageBucket: "dev-validator-test.appspot.com",
    messagingSenderId: "313228527018",
    appId: "1:313228527018:web:3dbaefd97fe8b0f98dd7d3"
  };

// Initialize Firebase
const app = initializeApp(firebaseConfig);
// const analytics = getAnalytics(app);
const auth = getAuth(app);
//Підключеня бази даних Firestore
const db = getFirestore(app);

// google pop up
const provider = new GoogleAuthProvider();
// sets pop up language
auth.useDeviceLanguage();

checkUserOnLoad();

//import {checkUserOnSignIn, tasksLoad, checkUserVersion} from "./firebaseFirestore.js";


// відповідає за появу вікна для авторизації через гугл аккаунт 
export async function popupGoogle(){
    signInWithPopup(auth, provider)
    .then((result) => {
        // успішна авторизація
        const user = result.user;
        checkUserOnSignIn(user.uid)
        .then( returnValue => {
            if(!returnValue){
                createUser(user.uid, user.displayName);
            }
        });
        localStorage.setItem("userDataPath", user.uid);
        // із-за перезавнтаження сторінки onAuthStateChanged може спрацювати двічі
        // що створює зайвий запит до бази даних
        window.location.reload();
    }).catch((error) => {
        // помилка при авторизації
        console.log("clicked the X or this:" + error);
        const btn = document.getElementById("loginBtn");
        btn.addEventListener("click", popupGoogle, {once: true});

    });
};

// спрацьовує на завантаженні сторінки
// перевіряє чи ввійшов користувач у систему
// перевіряє версію уже ввійшовшого користувача
export async function checkUserOnLoad(){
    onAuthStateChanged(auth, async function(user) {
        const btn = document.getElementById("loginBtn");

        if (user) {
            const uid = user.uid;
            //showModalResults(uid);
            // Якщо дійдуть руки, то буде перевірка версії через localStorage, а саме:
            // при вході користувача його документ зберігається локально, тоді
            // при зміні документу (наприклад при виконанні завданнь) потрібно буде
            // крім оновлення документу в базі даних, ще й оновляти локальний документ
            // ЗАВДЯКИ чому при перевірці версії запит документу користувача йде в локальне сховище,
            // що в свою чергу зменшує загальну кількість запитів на один при перевірці версії
            // АЛЕ перевірка версії відбувається досить часто (кожний раз коли спрацьовує onAuthStateChanged),
            // тому це може того вартувати
            // const userDocLocal = JSON.parse(localStorage.getItem("userData"));

            // перевіряє версійність
            const returnValue = await checkUserVersion(uid);
            console.log(returnValue);
            const correctVersion = returnValue[0] // boolean
            const userDoc = returnValue[1];
            const templateDoc = returnValue[2];
            if(!correctVersion){
                await mergeDocs(uid, userDoc, templateDoc);
            };
            // тепер кнопка відповідає за вихід користувача
            btn.innerText = "Вийти";

            btn.addEventListener("click", signOutVar, {once: true});
            
            // завантажує опції з документу користувача

            // checkUserVersion(null, null, uid, false);
            const select = document.getElementById("task");
            const obj = "option";
            // tasksLoad(select, obj, uid);

            //виведення даних користувача в меню та модальне вікно
            const userName = document.getElementById("userName");
            userName.innerText = user.displayName;
            document.getElementById("userNameModal").innerText = user.displayName;
            
            
        } else {
            showModalResults("template");
            // тепер кнопка відповідає за вхід користувача
            btn.innerText = "Увійти";
            btn.addEventListener("click", popupGoogle, {once: true});
            console.log("user is not signed in");

            // завантажує опціїї з шаблонного документу
            //const select = document.getElementById("task");
            //const obj = "option";
            // tasksLoad(select, obj, "template");
        }
    });
};

// Перевіряє чи існує документ користувача в базі даних
// Повертає Promise
export async function checkUserOnSignIn(uid){
    // uid - посилання на документ (userId), отримане при авторизації
    const theDoc = (await getDoc( doc(db, "main", uid) )).exists();

    if(!theDoc){
        return false;
    }else{
        return true;
    }
};


// Перевіряє версію документу користувача 
// додатково є можливість надати об'єкт даних користувача та об'єкт шаблону
// для того щоб за можливості не робити зайвого запиту до бази даних
export async function checkUserVersion(uid, userDoc, templateDoc){
    // uid - айді користувача
    // userDoc - об'єкт даних користувача
    // templateDoc - об'єкт шаблонних даних
        if(!uid && !userDoc){
            console.error("to check version you have to provide uid or userDoc");
            return;
        }
        if(!userDoc){
            try{
                userDoc = ( await getDoc( doc(db, "main", uid) ) ).data();      
            }catch(err){
                console.error(err);
                return;
            }
        }
        if(!templateDoc){
            try{
                templateDoc = ( await getDoc( doc(db, "main", "template") ) ).data();
            }catch(err){
                console.error(err);
                return;
            }
        }
        if(templateDoc.version == userDoc.version){
            return [true, userDoc, templateDoc];
        }else{
            return [false, userDoc, templateDoc];
        }
    };

   // createUser("21321321", "hgfhgfhg");
// Створення нового користувача та копіювання бази даних з шаблону template 
// uid - отримуємо з LocalStorage
// userName - отримуємо  при авторизації з Гугл аккаунту
async function createUser(uid, userName){
    const template = (await getDoc( doc(db, "main", "template"))).data();
    template.userName = userName;
    template.uid = uid;
    const ref = doc(db, "main", uid);
    await setDoc(ref, template); 
    //console.log("ok");
}

// З'єднує два документи (користувача та шаблону).
// Функція потрібена для версійності.
export async function mergeDocs(uid, userDoc, templateDoc){
    if(!uid && !userDoc){
        console.error("to merge template into userDoc you have to provide uid or userDoc");
        return;
    }
    if(!userDoc){
        userDoc = ( await getDoc( doc(db, "main", uid) ) ).data();
    }
    if(!templateDoc){
        templateDoc = ( await getDoc( doc(db, "main", template) ) ).data();
        // із-за мутації шаблоного документу після з'єднання
        // змінюється і його версія на ту що була в користувача, 
        // тому її збережено в примітивну змінну
    }
    var templateVersion = templateDoc.version;
    const mergedObject = mergeObjects(templateDoc, userDoc);
    mergedObject.version = templateVersion;
    // return mergeObjects(templateDoc, userDoc);
    await setDoc(doc(db, "main", uid), mergedObject);
}

// нажаль ця функція зміннює вхідні об'єкти 
// (наразі проблем з цим немає, але можуть виникнути у майбутньому)
// я намагався зробити її через функційне програмування,
// але мені не вистачає часу це доробити, тому поки що залишив так
export function mergeObjects(mergeFrom,mergeIn){
    // mergeFrom - шаблон з новими властивостями
    // mergeIn - об'єкт зі значеннями, які потрібно зберегти
    // проходиться по кожній властивості mergeFrom 
    // (припускається, що mergeFrom має більше властивостей, ніж mergeIn)
    // console.log(mergeFrom,mergeIn);
    Object.entries(mergeFrom).forEach(property => {
        const mergeInPropertyObj = mergeIn[property[0]];
        const mergeFromPropertyObj = property[1];
        if(
            typeof property == "object" &&
            typeof mergeFromPropertyObj == "object" &&
            !Array.isArray(mergeFromPropertyObj) &&
            property !== null &&
            mergeInPropertyObj
        ){
            // якщо властивість має непримітивне значення (об'єкт) 
            // та якщо ця властивість має теж ім'я, що й у mergeIn 
            // якщо значення другого об'єкту існує
            // поєднує вкладені об'єкти 
            mergeObjects(mergeFromPropertyObj, mergeInPropertyObj);            

        }else if(Array.isArray(mergeFromPropertyObj)){
            // якщо властивість має непримітивне значення (масив)
            // надає властивості шаблонного об'єкту масив неповторних значень
            mergeFrom[property[0]] = mergeUnique(mergeFromPropertyObj,mergeInPropertyObj);

        }else if(mergeInPropertyObj !== undefined && mergeInPropertyObj !== null){
            // якщо властивість має примітивне значення
            // якщо значення другого об'єкту існує
            // надає властивості шаблонного об'єкту значення другого об'єкту
            mergeFrom[property[0]] = mergeInPropertyObj;
        };
    });
    // повертає зміненний шаблонний об'єкт
    return mergeFrom;
};

// поєднує унікальні елементи в масиві 
// (на майбутнє, якщо прийдеться використовувати масиви)
// вкрадено з https://stackoverflow.com/a/44464083
function mergeUnique(arr1, arr2){
    return arr1.concat(arr2.filter(function (item) {
        return arr1.indexOf(item) === -1;
    }));
};



// вихід користувача
const signOutVar = async function(){
    signOut(auth).then(() => {
        localStorage.clear();
        window.location.reload();
        // showModalResults("template");
        // future popUp here
        }).catch((error) => {
        // future error popUp here
        });
};



// ------------------------------------------------------------------------------------

//Робота з базою даних

let uid = localStorage.getItem("userDataPath");

if(!uid){
    uid = "template";
};




//Get all documents in a collection
async function showModalResults(uid){

    
    // const docRef = db.collection("main").doc(uid);
    const docRef = doc(db, "main", uid);
    const templateDoc = await getDoc(docRef);
    
        if (templateDoc.exists) {
            //console.log("Document data:", doc.data());
            
            var tasksList = templateDoc.data().tasks;
            Object.entries(tasksList).sort().forEach(property => {
    
               let lessonsList = document.getElementById('userResult');
    
               //https://learn.javascript.ru/modifying-document Изменение документа
               //контейнер для відображення результатів
               let divLessons = document.createElement('div');
               divLessons.className = "divLessons";
               lessonsList.insertAdjacentElement('beforeend',divLessons);
    
               //Відображення назви курсу 
               const lessonName = property[0];    
               let divLessonName = document.createElement('div');
               divLessonName.id = lessonName;
               divLessonName.className = "divLessonName";               
               divLessons.insertAdjacentElement('afterbegin',divLessonName);
    
               let h3LessonName = document.createElement('h3');
               h3LessonName.innerHTML = lessonName;
               divLessonName.insertAdjacentElement('afterbegin',h3LessonName);
    
    
                //контейнер для відображення результатів завдань
                let divTasks = document.createElement('div');
                divTasks.className = "divTasks";
                divLessons.insertAdjacentElement('beforeend',divTasks);
              
                   
               Object.entries(property[1]).sort().forEach(property =>{
    
                //посилання на завдання
    
                let aTask = document.createElement('a');
                
                //умова на шлях до різних папок
                let path = window.location.href;
                let file = path.substring(path.length, path.length-8);
                
                if (file == 'task.php'){
                    aTask.href = "../../tasks/" + lessonName+"_" + property[0] + "/task.php";
                } else {
                    aTask.href = "tasks/" + lessonName+"_" + property[0] + "/task.php";
                }
                
                aTask.class = "a-class";
                divTasks.insertAdjacentElement('beforeend',aTask);
                let divTaskResult = document.createElement('div');
                divTaskResult.id = lessonName + "_" + property[0];
                divTaskResult.className = "divTaskResult";                
                aTask.insertAdjacentElement('beforeend',divTaskResult);
                
                //заголовок назва завдання
                let h4TaskName = document.createElement('h3');
                h4TaskName.innerHTML = property[0];
                divTaskResult.insertAdjacentElement('afterbegin',h4TaskName);
    
                //результат виконання завдання
                let h5TaskResult = document.createElement('h5');
                h5TaskResult.innerHTML = property[1]+"%";
                divTaskResult.insertAdjacentElement('beforeend',h5TaskResult);
    
                //графічне відображення прогресу https://ru.stackoverflow.com/questions/110066/%D0%9A%D0%B0%D0%BA-%D1%81%D0%B4%D0%B5%D0%BB%D0%B0%D1%82%D1%8C-%D1%84%D0%BE%D0%BD-%D0%B1%D0%BB%D0%BE%D0%BA%D0%B0-div-html-%D0%BD%D0%B5-%D0%B4%D0%BE-%D0%BA%D0%BE%D0%BD%D1%86%D0%B0
                let progress = document.createElement('progress');
                progress.min = 0;
                progress.max = 100;
                progress.value = property[1];
                divTaskResult.insertAdjacentElement('beforeend',progress);
    
                //console.log(property[0],":", property[1]);
               })
    
            });  
        } else {
            // doc.data() will be undefined in this case
            console.log("No such document!");
        }
    

}
// ______________________________________________________________________________________________
// ______________________________________________________________________________________________
// ______________________________________________________________________________________________
// ______________________________________________________________________________________________
// ______________________________________________________________________________________________
// ______________________________________________________________________________________________

async function testSend(input){
    const uid = localStorage.getItem("userDataPath");
    // const userDoc = (await getDoc(doc(db,"main", uid))).data();
    await updateDoc(doc(db, "main", uid), input);
    // console.log(result);
}
async function testGet(defOutObj, taskTheme, task){
    // defOutObj - об'єкт в які владені теми завданнь
    // taskTheme - тема завдань (з номером на початку)
    // task -  номер завдання
    const uid = localStorage.getItem("userDataPath");
    const toReturn = ( await getDoc(doc(db,"main",uid))).data()[defOutObj][taskTheme][task];
    return toReturn;
}
export {testSend, testGet};

// signOutVar();