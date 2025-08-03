/* Write your T-SQL query statement below */

SELECT 
    out_employee.Name
FROM (
    SELECT 
        manager.managerId,
        COUNT(1) as employees_per_manager
    FROM employee AS manager
        LEFT JOIN employee ON employee.id = manager.id
    WHERE manager.managerId IS NOT NULL
    GROUP BY manager.managerId
) as m
JOIN 
    employee as out_employee ON out_employee.id = m.managerId
WHERE m.employees_per_manager >= 5


