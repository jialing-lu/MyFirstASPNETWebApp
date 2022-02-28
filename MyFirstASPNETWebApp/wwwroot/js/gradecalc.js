///Grade calculator
$("#submit").click(() => {

    // Declare variables for each input box
    let assignments = $("#assignments").val() * 0.55;
    let group_project = $("#group_project").val() * 0.05;
    let quizzes = $("#quizzes").val() * 0.1;
    let exams = $("#exams").val() * 0.2;
    let intex = $("#intex").val() * 0.1;


    let tScore = assignments + group_project + quizzes + exams + intex;
    tScore = toFixed(2);

    let letterGrade = "";

    // Let the calculator decide the letter grade based on the total grade (percentage). 

    if (tScore <= 100 && tScore >= 94) {
        letterGrade = "A";
    }
    else if (tScore < 94 && tScore >= 90) {
        letterGrade = "A-";
    }
    else if (tScore < 90 && tScore >= 87) {
        letterGrade = "B+";
    }
    else if (tScore < 87 && tScore >= 84) {
        letterGrade = "B";
    }
    else if (tScore < 84 && tScore >= 80) {
        letterGrade = "B-";
    }
    else if (tScore < 80 && tScore >= 77) {
        letterGrade = "C+";
    }
    else if (tScore < 77 && tScore >= 74) {
        letterGrade = "C";
    }
    else if (tScore < 74 && tScore >= 70) {
        letterGrade = "C-";
    }
    else if (tScore < 70 && tScore >= 67) {
        letterGrade = "D+";
    }
    else if (tScore < 67 && tScore >= 64) {
        letterGrade = "D";
    }
    else if (tScore < 64 && tScore >= 60) {
        letterGrade = "D-";
    }
    else if (tScore < 60) {
        letterGrade = "E";
    }
    else {
        letterGrade = "F";
    }

    sessionStorage.setItem('totalpct', tScore);
    sessionStorage.setItem('letGrade', letterGrade);
});