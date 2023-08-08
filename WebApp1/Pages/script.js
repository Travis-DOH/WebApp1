// add button
var button = document.createElement("button");

// add text to button
button.innerHTML = "Click Me";

// add button to body
document.body.appendChild(button);

// add event listener to button
button.addEventListener("click", function () { // increment counter
    counter++;
    // set text field value to counter
    textField.value = counter;
});

// add text field that displays counter
var textField = document.createElement("input");

// set text field to read only
textField.readOnly = true;

// add text field to body
document.body.appendChild(textField);
