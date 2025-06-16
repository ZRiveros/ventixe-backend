# Ventixe – Backend API (users-api)

Detta är backend-delen av MVP-projektet *Ventixe*, utvecklat i kursen **Molntjänster och distribuerade system**.

## 🔐 Funktionalitet (JWT-skyddad API)

API:t är byggt med ASP.NET Core Web API och skyddas med JWT-tokens.

### Endpoints:

- `POST /api/users/register`  
  Registrerar en ny användare (användarnamn + lösenord)

- `POST /api/users/login`  
  Autentiserar användaren och returnerar en JWT-token

- `GET /api/users/secure`  
  Skyddad route – kräver `Authorization: Bearer <token>`

## 🧪 Testning via Swagger

Du kan testa alla endpoints via Swagger UI:

🔗 `http://localhost:<PORT>/swagger`  
> Ersätt `<PORT>` med den port som projektet körs på (ex. 5001)

## ⚙️ Teknisk stack

- ASP.NET Core 8.0
- In-memory storage (ingen databas)
- JWT-autentisering via `Microsoft.AspNetCore.Authentication.JwtBearer`
- Swagger-dokumentation

## 🗂️ Struktur

