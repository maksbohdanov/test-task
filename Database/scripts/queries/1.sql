--list of tickets with customers data
SELECT
	t.id AS 'Ticket id',
	(SELECT name FROM City WHERE id = r.city_id_from) AS 'From',
	(SELECT name FROM City WHERE id = r.city_id_to) AS 'To',
	com.name AS 'Company',
	r.date_time AS 'Date',
	p.name AS 'Plane',
	r.price AS 'Price',
	CONCAT(c.first_name, ' ', c.last_name) AS 'Customer',
	c.email AS 'Email',
	c.phone AS 'Phone',
	c.passport AS 'Passport'	
FROM Ticket AS t
JOIN Customer AS c ON c.id = t.customer_id
JOIN Race AS r ON r.id = t.race_id
JOIN Plane AS p ON p.id = r.plane_id
JOIN Company AS com ON com.id = p.company_id