# PrintStudio (.NET projekt)

Semestralni projekt izrađen u .NET tehnologijama:
- **Blazor Web App** (frontend)
- **ASP.NET Core Web API** (backend endpointi)
- **Entity Framework Core + SQLite** (podatci)

## Funkcionalnosti
- Početna stranica s hero sekcijom, prednostima, izdvojenim proizvodima i recenzijama
- Popis proizvoda s filtriranjem po kategoriji
- O nama sekcija s KPI statistikama
- Kontakt forma s validacijom i spremanjem upita
- API endpointi:
  - `GET /api/products`
  - `GET /api/products/{id}`
  - `POST /api/products`
  - `GET /api/testimonials`
  - `POST /api/contactrequests`
  - OpenAPI specifikacija dostupna u Development okruženju na `/openapi/v1.json`

## Pokretanje
```bash
dotnet restore
dotnet run --project src/PrintStudio/PrintStudio.csproj
```

## Napomena
U ovom okruženju `dotnet` CLI možda nije instaliran. Kod je spreman za pokretanje lokalno na stroju s .NET 8 SDK-om.
