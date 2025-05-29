# TipsterApp
Aplikace pro správu a zadávání spropitného v kavárně.  
Umožňuje zadávat spropitné ke stolu, sledovat statistiky, validovat vstupy, exportovat data přes REST API a vše běží na moderním Blazoru (.NET 8).

---

## Funkce

- Zadávání a úprava spropitného u stolu (Table ID)
- Výběr spropitného (procenta nebo vlastní částka)
- Validace vstupů (email, hodnocení, částky)
- Zobrazení nejvyššího spropitného dne a celkové částky
- Statistiky: celková částka, nejvyšší spropitné, průměrné procento, průměrné hodnocení
- REST API pro export dat (dokumentace přes Swagger, zabezpečeno tokenem)
- Přepínání úložiště (InMemory/JSON)
- Background service pro výpočet statistik

---

## Jak spustit aplikaci

1. **Otevři solution ve Visual Studiu**
   - Soubor `TipsterApp.sln`
   - Stiskni F5 nebo spusť projekt `TipsterApp`

---

## Přepnutí úložiště

V konfiguračním souboru (`appsettings.json`) nastav typ úložiště:
- `InMemory` – data jen v paměti
- `Json` – data se ukládají do souboru (umístění souboru: TipsterApp\tips.json)

---

## REST API a dokumentace

- Otevři **Swagger UI** v prohlížeči po spuštění aplikace (typicky na `https://localhost:{port}/swagger`)
- Zobrazí se popis všech dostupných endpointů a možnost jejich otestování
- API je chráněné tokenem – použij tlačítko **"Authorize"**
- Autorizační token, který je třeba zadat do pole "Value" ve formuláři "Available authorizations" je: Bearer tokenValue

---

## Testování

- Projekt obsahuje jednoduchý unit test v projektu `TipsterApp.Tests`
- Test najdeš ve třídě `TipStorageTests.cs`
- Ověřuje, že po uložení tipu lze záznam správně načíst:
  - počet záznamů je 1
  - ID stolu a výše spropitného odpovídají

---

## Použité technologie

- .NET 8, Blazor Web App
- C#
- REST API (Swagger/OpenAPI)
- Background Service
- Bootstrap/CSS

---

## Autor

Josef Procházka  
prochazka@email.cz

---

*Good luck and, most importantly, have fun!*
