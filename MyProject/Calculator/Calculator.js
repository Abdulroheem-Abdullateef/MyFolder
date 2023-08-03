// let displayText = "0";
// let firstNo = 0;
// let secondNo = 0;
// let operation = null;
// let isSubmitActive = false;

// function typeNumbers() {
//     const numbers = document.querySelectorAll('.num');
//     const inputField = document.querySelector('.inputField');

//     numbers.forEach(num => {
//         num.addEventListener('click', (e) => {
//             console.log(isSubmitActive)
//             if (inputField.innerHTML !== "0" && !isSubmitActive) {
//                 displayText += e.target.innerHTML;

//             }
//             else {

//                 displayText = e.target.innerHTML;
//             }
//             inputField.innerHTML = displayText;
//         })
//     })
// }


// function typeOperation() {
//     const operators = document.querySelectorAll('.operator');
//     const inputField = document.querySelector('.inputField');

//     operators.forEach(operand => {
//         operand.addEventListener('click', (e) => {
//             isSubmitActive = false;
//             if(operation !== null)
//             {
//                 const manipulate = inputField.innerHTML.split(' ');
//                 secondNo = manipulate[manipulate.length-1];
//                 displayText = operate(firstNo, secondNo)[operation] + " " + e.target.innerHTML + " ";
//                 firstNo = operate(firstNo, secondNo)[operation];
//                 operation = e.target.innerHTML;
//                 inputField.innerHTML = displayText;

//             }
//             else{
//                 operation = e.target.innerHTML;
//                 firstNo = inputField.innerHTML;
//                 const manipulate = " " + operation + " ";
//                 displayText += manipulate; 
//                 inputField.innerHTML = displayText;
//             }


//         })
//     })
// }

// const operate = (num1, num2) => {
//     const operating = {
//         "+": parseFloat(num1) + parseFloat(num2),
//         "-": parseFloat(num1) - parseFloat(num2),
//         "*": parseFloat(num1) * parseFloat(num2),
//         "/": parseFloat(num1) / parseFloat(num2)
//     }
//     return operating;
// }

// function performOperation() {
//     const submitBtn = document.querySelector('#result');
//     const inputField = document.querySelector('.inputField');


//     submitBtn.addEventListener('click', () => {
//         if (operation !== null) {
//             isSubmitActive = true;
//             const manipulate = inputField.innerHTML.split(' ');
//             secondNo = manipulate[manipulate.length-1];
//             console.log(firstNo, secondNo)
//             inputField.innerHTML = operate(firstNo, secondNo)[operation];
//             displayText = inputField.innerHTML;
//             operation = null;
//         }
//     })


// }

// typeNumbers();
// typeOperation();
// performOperation();

// start yours
let value = '';
let inputDisplay = document.querySelector('#input'),
    pressedValue = document.querySelectorAll('.num'),
    operators = document.querySelectorAll('.operator'),
    clearButton = document.querySelector('#clear'),
    result = document.querySelector('#result');

clearButton.addEventListener('click', () => {
    inputDisplay.innerHTML = '0'
});

result.addEventListener('click', (e) => { inputDisplay.innerHTML = pressedValue
});

pressedValue.forEach(num => {
    num.addEventListener('click', (e) => {
        let checkInput = inputDisplay.innerHTML;
        if (checkInput != '0') {
            inputDisplay.innerHTML += e.target.innerHTML;
        }
        else {
            inputDisplay.innerHTML = e.target.innerHTML;
        }
        value = inputDisplay.innerHTML;
    })
})
for (let i = 0; i < operators.length; i++) {
    operators[i].addEventListener('click', (e) => {
        let currentString = inputDisplay.innerHTML;
        let laststring = currentString[currentString.length - 1];
        if (laststring == '0') {
            console.log("enter a number first")
        }
        else if (laststring === '+' || laststring === '-' || laststring === '*' || laststring === '/') {
            let newString = currentString.substring(0, currentString.length - 1);
            inputDisplay.innerHTML = newString + e.target.innerHTML;
        }
        else {
            inputDisplay.innerHTML += e.target.innerHTML;
        }
    })

}
