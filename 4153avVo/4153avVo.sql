select
    subjects.name as 科目名,
    count( students.enrollment_year = 2023 or null ) as "1年生履修者数",
    count( students.enrollment_year = 2022 or null ) as "2年生履修者数"
from registrations
inner join students on registrations.student_id = students.id
inner join subjects on registrations.subject_id = subjects.id
group by 科目名
