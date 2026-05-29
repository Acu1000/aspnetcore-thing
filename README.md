# Opis
Projekt jest prostym API do przechowywania listy pinezek oznaczających lokalizacje na mapie. Zaimplementowany jest system logowania, endpointy CRUD, baza danych, walidacja danych i obsługa błędów.

# Instrukcja przykładowego uruchomienia

### Uruchomienie:
dotnet ef database update
dotnet run

### Utworzenie konta (niepoprawne hasło):
http POST localhost:5090/api/auth/register Username=user1 Password=abc

### Utworzenie konta (poprawnie)
http POST localhost:5090/api/auth/register Username=user1 Password=abc123

### Próba logowania (niepoprawne hasło)
http POST localhost:5090/api/auth/login Username=user1 Password=abc1234

### Próba logowania (poprawne hasło)
http POST localhost:5090/api/auth/login Username=user1 Password=abc123

### Pobranie listy pinezek (pusta)
http GET localhost:5090/api/pins

### Utworzenie pinezki
http POST localhost:5090/api/pins Id=124214214 Latitude=50 Longitude=20 Title=title Authorization:"Bearer "

### Pobranie już nie pustej listy pinezek
http GET localhost:5090/api/pins 

### Próba utworzenia pinezki bez autoryzacji:
http POST localhost:5090/api/pins Id=124214214 Latitude=55 Longitude=22 Title=title2

### Strona błędu z globalną obsługą:
http get localhost:5090/Throw

### Strona z obsłużonym problemem:
http get localhost:5090/Teapot


