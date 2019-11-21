<!DOCTYPE html>
<html>
<head>
     <title>Store a student information</title>

</head>

<body>
    <div id="form">
       <form action="process.php" method="POST">
          <P>
              <label>Student Name</label>
              <input type="text"id="stu_name"name="student_name"/>

          </p>
          <P>
              <label>Student Age</label>
              <input type="text"id="stu_age"name="student_ages"/>

          </p>
          <P>
              <label>Student Gender</label>
              <input type="text"id="stu_gen"name="student_gender"/>

          </p>
          <P>
              <label>Did he/she pass the exam ?</label>
              <input type="text"id="stu_exa"name="student_grade_status"/>

          </p>
          <P>
              <input type="submit"id="button"value="login"/>

          </p>

        </form>

        </div>
  </body>

</html>
