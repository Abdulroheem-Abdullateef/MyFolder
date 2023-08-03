// var displayScreen = document.querySelector("#input-tag");
// displayScreen.innerHTML = "<div id = 'btn-container' class = 'btn'> </div>"
// let x = "";
// Array.from(document.getElementsByClassName("btn-tag")).forEach(item =>{
//     item.addEventListener("click" , () => 
//     {

//         x+= `${item.innerText}`
//         displayScreen.children[0].innerHTML = x;
//     })

// })

// function buttonNumber(num) {

// }



// let screen = document.querySelector(".screen");
// let buttons = document.querySelectorAll(".btn");
// let equal = document.querySelector(".btn-equal");
// let clear = document.querySelector(".btn-clear");


// function buttonFunction() {
//     buttons.forEach(function (button) {
//         button.addEventListener('click', function (e) {
//             let value = e.target.dataset.num;
//             screen.value += value;
//         })
//     });
// }



// equal.addEventListener('click', function () {


// });
// buttonFunction();

// clear.addEventListener('click', function (e) {
//     screen.value = "";
// });



let display = document.getElementById("display");
let buttons = Array.from(document.getElementsByClassName('button'));

buttons.map(button => {
    button.addEventListener('click', (e) => {
        switch (e.target.innerText) {
            case 'Clear':
                display.innerText = " ";
                break;

            case 'Back':
                if (display.innerText) {
                    display.innerText = display.innerText.slice(0, -1);
                }
                break;

            case '=':

                try {
                    display.innerText = eval(display.innerText);
                } catch {
                    display.innerText = "Syntax Error";
                }
                break;

            default:
                display.innerText += e.target.innerText;
                break;
        }
    })
})








