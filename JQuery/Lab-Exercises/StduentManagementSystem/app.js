const API_URL = "students.json";
let students = [];
let currentPage = 1;
const rowsPerPage = 5;

function loadStudents() {
    $.getJSON(API_URL, function(data) {
        students = data;
        displayStudents();
        setupPagination();
    });
}

function displayStudents(page = 1) {
    let tbody = $("#studentTable tbody");
    tbody.empty();
    const start = (page-1)*rowsPerPage;
    const paginatedStudents = students.slice(start, start+rowsPerPage);

    paginatedStudents.forEach(s => {
        tbody.append(`
            <tr>
                <td>${s.id}</td>
                <td>${s.name}</td>
                <td>${s.age}</td>
                <td>${s.grade}</td>
                <td>
                    <button class="editBtn" data-id="${s.id}">Edit</button>
                    <button class="deleteBtn" data-id="${s.id}">Delete</button>
                </td>
            </tr>
        `);
    });
}


function setupPagination() {
    const pageCount = Math.ceil(students.length / rowsPerPage);
    let pagination = $("#pagination");
    pagination.empty();

    for(let i=1; i<=pageCount; i++){
        pagination.append(`<button class="pageBtn" data-page="${i}">${i}</button>`);
    }
}

// Search
$("#search").on("input", function() {
    const query = $(this).val().toLowerCase();
    students = students.filter(s => s.name.toLowerCase().includes(query));
    displayStudents();
});

// Filter by grade
$("#filterGrade").on("change", function() {
    const grade = $(this).val();
    if(grade) {
        students = students.filter(s => s.grade === grade);
    } else {
        loadStudents();
    }
    displayStudents();
});

// Save / Add Student
$("#saveBtn").click(function() {
    const id = $("#studentId").val();
    const name = $("#name").val();
    const age = $("#age").val();
    const grade = $("#grade").val();

    if(!name || !age || !grade){
        alert("All fields are required!");
        return;
    }

    if(id){ // Edit
        const index = students.findIndex(s => s.id == id);
        students[index] = {id: parseInt(id), name, age: parseInt(age), grade};
    } else { // Add
        const newId = students.length ? students[students.length-1].id + 1 : 1;
        students.push({id: newId, name, age: parseInt(age), grade});
    }

    clearForm();
    displayStudents();
    setupPagination();
});

// Edit Student
$(document).on("click", ".editBtn", function() {
    const id = $(this).data("id");
    const student = students.find(s => s.id == id);
    $("#studentId").val(student.id);
    $("#name").val(student.name);
    $("#age").val(student.age);
    $("#grade").val(student.grade);
});

// Delete Student
$(document).on("click", ".deleteBtn", function() {
    const id = $(this).data("id");
    students = students.filter(s => s.id != id);
    displayStudents();
    setupPagination();
});

// Clear form
$("#clearBtn").click(clearForm);
function clearForm(){
    $("#studentId").val("");
    $("#name").val("");
    $("#age").val("");
    $("#grade").val("");
}

// Pagination click
$(document).on("click", ".pageBtn", function(){
    currentPage = $(this).data("page");
    displayStudents(currentPage);
});

// Initial load
$(document).ready(loadStudents);