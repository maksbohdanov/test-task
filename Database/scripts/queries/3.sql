--top 3 customers by ticket count
SELECT TOP 3 *, 
	(SELECT Tickets 
    FROM
		(SELECT customer_id AS ID, COUNT(*) AS Tickets
		FROM ticket		
		GROUP BY customer_id) AS T1
	WHERE  ID = customer.id) AS Tickets		
FROM Customer
ORDER BY Tickets DESC;