--5 tickets for the last race
SELECT TOP 5
	t.id AS 'Ticket id',
	(SELECT name FROM City WHERE id = r.city_id_from) AS 'From',
	(SELECT name FROM City WHERE id = r.city_id_to) AS 'To',
	com.name AS 'Company',
	r.date_time AS 'Date',	
	p.name AS 'Plane',
	r.price AS 'Price',
	r.id
FROM Ticket AS t
JOIN Race AS r ON r.id = t.race_id
JOIN Plane AS p ON p.id = r.plane_id
JOIN Company AS com ON com.id = p.company_id
WHERE r.date_time = (SELECT MAX(date_time) FROM Race)