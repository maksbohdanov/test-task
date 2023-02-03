------------------- company --------------------------
INSERT INTO Company (name) VALUES ('Ã¿”');
INSERT INTO Company (name) VALUES ('AIRBALTIC');
INSERT INTO Company (name) VALUES ('ALITALIA');
INSERT INTO Company (name) VALUES ('BRITISH AIRWAYS');
INSERT INTO Company (name) VALUES ('EMIRATES');
INSERT INTO Company (name) VALUES ('KLM');
INSERT INTO Company (name) VALUES ('LOT');
INSERT INTO Company (name) VALUES ('LUFTHANSA');
INSERT INTO Company (name) VALUES ('TURKISH AIRLINES');
INSERT INTO Company (name) VALUES ('WIZZAIR');

------------------- status --------------------------
INSERT INTO Status (label) VALUES ('—heck-in');
INSERT INTO Status (label) VALUES ('Last call');
INSERT INTO Status (label) VALUES ('Scheduled');
INSERT INTO Status (label) VALUES ('Delayed');
INSERT INTO Status (label) VALUES ('Cancelled');
INSERT INTO Status (label) VALUES ('Boarding');
INSERT INTO Status (label) VALUES ('Departed');

------------------- seat_type --------------------------
INSERT INTO Seat_Type(label) VALUES ('1-seat');
INSERT INTO Seat_Type(label) VALUES ('2-seat');
INSERT INTO Seat_Type(label) VALUES ('3-seat');
INSERT INTO Seat_Type(label) VALUES ('Premium');

------------------- seat --------------------------
INSERT INTO Seat (quantity, seat_type_id) VALUES ('45', '1');
INSERT INTO Seat (quantity, seat_type_id) VALUES ('150', '3');
INSERT INTO Seat (quantity, seat_type_id) VALUES('100', '2');
INSERT INTO Seat (quantity, seat_type_id) VALUES ('15', '4');
INSERT INTO Seat (quantity, seat_type_id) VALUES ('30', '1');
INSERT INTO Seat (quantity, seat_type_id) VALUES ('60', '3');
INSERT INTO Seat (quantity, seat_type_id) VALUES ('45', '2');
INSERT INTO Seat (quantity, seat_type_id) VALUES ('6', '4');
INSERT INTO Seat (quantity, seat_type_id) VALUES ('80', '1');
INSERT INTO Seat (quantity, seat_type_id) VALUES ('200', '3');
INSERT INTO Seat (quantity, seat_type_id) VALUES ('145', '2');
INSERT INTO Seat (quantity, seat_type_id) VALUES ('35', '4');