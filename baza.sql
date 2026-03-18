CREATE DATABASE projekat_2026_MilosPusicA
use projekat_2026_MilosPusicA
CREATE TABLE Korisnik(
id INT IDENTITY PRIMARY KEY,
email NVARCHAR(40),
pass NVARCHAR(20),
uloga INT
)