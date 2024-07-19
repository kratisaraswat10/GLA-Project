let display = document.getElementById('display')

function clearFunc() {
    display.innerText = "0"
}

function backspace() {
    if (display.innerText != "0" && display.innerText.length > 1) {
        display.innerText = display.innerText.slice(0, -1);
    }
    else {
        display.innerText = "0"
    }
}

function appendToDisplay(value) {
    if (display.innerText === "0") {
        display.innerText = value
    }
    else {
        display.innerText += value
    }
}

function calculate() {
    try {
        display.innerText = eval(display.innerText)
    }
    catch (e) {
        display.innerText = "Error"
    }
}