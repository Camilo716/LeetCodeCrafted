/* Write your T-SQL query statement below */

SELECT 
    Name
FROM employee
WHERE id IN (
    SELECT 
        managerId
    FROM employee
    GROUP BY managerId
    HAVING count(1) >= 5
)


