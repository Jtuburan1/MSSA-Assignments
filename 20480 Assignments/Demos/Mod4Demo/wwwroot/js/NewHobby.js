document.addEventListener('DOMContentLoaded', function (event) {
    document.getElementById('newHobbyBtn').addEventListener('click', addHobbies);
});

function addHobbies() {
    // get all hobbies input boxes
    const inputlist = document.querySelectorAll('.hobbiesInput');

    if (inputlist.length < 5) {

        // getting ref for div ( parent node)
        const hobbieslist = document.getElementById('hobbieslist');

        let newlineelement = CreateNode('br'); //create br
        let newlineelement1 = CreateNode('br'); //create br
        const inputelement = CreateNode('input'); // create input text

        inputelement.setAttribute("class", "hobbiesInput");

        append(hobbieslist, newlineelement); // add <br> into div
        append(hobbieslist, newlineelement1);
        append(hobbieslist, inputelement);// add input text box in div

    }
    else {
        alert("Just 5 hobbies!");
        document.getElementById('newHobbyBtn').removeEventListener('click', addHobbies);

    }



}

function CreateNode(element) {
    return document.createElement(element);

}

function append(parent, el) {
    return parent.appendChild(el);
}