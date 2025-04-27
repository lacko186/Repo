# KaposTransit
## Bevezetés


### Felhasználói felület

A KaposTransit interaktív térképes megjelenítést biztosít a következő funkciókkal:
- **Információs panel**: Részletes járatinformációk, menetrendek és aktuális hírek megjelenítése
- **Módok közötti váltás**: Egyszerű navigáció különböző nézetek között (térkép, lista, keresés)
- **Google Maps API integráció**: Megbízható térképes alaprendszer a pontos helymeghatározáshoz és útvonalak megjelenítéséhez
- **Összes megálló vizualizáció**: A város teljes buszhálózatának áttekintése egy felületen
- **Interaktív megállókereső**: Felhasználóbarát keresőrendszer a megállók gyors megtalálásához

### Technológiai támogatás

#### JSON alapú adatkezelés
Rendszerünk JSON formátumban tárolja és kezeli az adatokat, ami hatékony adatátvitelt és feldolgozást tesz lehetővé. Ez a formátum rugalmas és könnyen bővíthető struktúrát biztosít, valamint hatékonyan kezelhető JavaScript környezetben.

#### MÁV architektúra adaptálás (GTFS)
A MÁV által használt formátumot adaptáltuk a nemzetközileg elismert General Transit Feed Specification (GTFS) szabványra. Ez a megoldás biztosítja:
- A menetrendi adatok szabványos kezelését
- A különböző közlekedési rendszerekkel való kompatibilitást
- Az útvonalak, megállók és menetrendek egységes ábrázolását
- A rendszer jövőbeli bővíthetőségét

#### Dinamikus menetrend frissítés
A rendszer képes automatikusan frissíteni a menetrendet a szolgáltatótól érkező adatok alapján, így mindig naprakész információkat biztosít. A frissítési mechanizmus kezeli a menetrend-változásokat, különleges eseményeket és az ideiglenes módosításokat is.

### Szakmai együttműködés

Projektünk szakmai támogatója a MenetBrand, amely biztosítja:
- **API alapú menetrend szolgáltatás**: RESTful API interfészen keresztül jutunk hozzá a menetrendi adatokhoz
- **Szakmai mentorálás**: Tapasztalt szakemberek segítik a fejlesztési folyamatot, biztosítva a projekt szakmai színvonalát
- **Rendszertámogatás és infrastruktúra**: Megbízható háttérrendszerek a stabil működéshez, beleértve a szervereket, hálózati erőforrásokat és biztonsági megoldásokat

## Adminisztrációs felület

Az üzemeltetéshez PHP/MySQL alapú adminisztrációs felületet fejlesztettünk, amely tartalmazza:
- **Bejelentkezés-védett kezelőpanel**: Biztonságos hozzáférés csak jogosult felhasználóknak, többszintű jogosultsági rendszerrel
- **Irányítópult statisztikákkal**: Forgalmi adatok, felhasználói aktivitás és rendszerteljesítmény monitorozása valós időben
- **Késés-kezelő űrlapok**: Valós idejű bejegyzések készítése a menetrendi eltérésekről, amelyek automatikusan megjelennek a felhasználói felületen
- **Hír és kép menedzsment**: Aktuális információk és vizuális tartalmak kezelése, beleértve a feltöltést, szerkesztést és kategorizálást
- **Felhasználóbarát működés**: Intuitív kezelőfelület, amely minimális betanítást igényel és hatékony munkavégzést tesz lehetővé

## Backend Architecture

Our backend system is built on Node.js technology, providing:
- **Server (localhost:3000) Endpoint**: A robust server environment running on localhost:3000 during development
- Fast, non-blocking I/O operations for efficient data processing
- Concurrent request handling for smooth user experience even under heavy load
- RESTful API endpoints for flexible integration with various client applications
- Scalable architecture design that can easily accommodate future expansion and increased traffic

### API Documentation

To support development and integration efforts, we've implemented:
- **Swagger Documentation**: Comprehensive interactive API documentation system that provides detailed specifications for all available endpoints
- Request and response schemas with examples
- Authentication and authorization requirements
- Test functionality directly from the browser interface
- **Postman Collection**: Ready-to-use request collections organized by functional area
- Environment variables for different deployment scenarios
- Pre-request scripts for authentication and test scripts for response validation
- Rapid onboarding tool for new developers joining the project

## Team Work

Our development process emphasizes effective collaboration:
- **GitHub Repository**: Central code storage and version control system
  - Branch protection rules to maintain code quality
  - Pull request workflow with code review requirements
  - CI/CD integration for automated testing
- **Team Collaboration**: Structured approach to project management
  - Task distribution based on expertise and capacity
  - Regular scrum meetings for progress tracking
  - Documentation of decisions and design choices
- **Code Sharing**: Practices to ensure knowledge transfer
  - Pair programming for complex features
  - Code reviews to share expertise and ensure quality
  - Comprehensive inline documentation

## Problem Statement

The KaposTransit project addresses several critical issues with the existing public transportation information system in Kaposvár:

- **Negative User Feedback on Kaposbusz**: Customer satisfaction surveys revealed widespread frustration with the current information delivery methods. Users reported difficulty planning trips, uncertainty about schedules, and lack of trust in the published information due to inconsistencies and outdated data.

- **Difficult Navigation System**: The existing system relies on fragmented information sources scattered across different platforms and physical locations. Users must navigate between multiple disconnected interfaces to gather complete journey information, creating significant cognitive load and barriers to public transport adoption.

- **PDF Timetables**: The current reliance on static PDF documents creates numerous usability problems, including poor accessibility for users with disabilities, inability to search effectively, difficulty viewing on mobile devices, and no capability for real-time updates when service changes occur. These limitations significantly impact the user experience and operational efficiency.

## Future Development

Our strategic roadmap for KaposTransit includes several key enhancements to further improve the system's value and functionality:

- **Online Ticket System with Personal Profiles**: An integrated digital ticketing platform that will allow users to purchase and store virtual tickets, manage subscriptions, and access personalized travel history. The system will support multiple payment methods, offer loyalty programs, and provide usage analytics to help users optimize their travel expenses.

- **Real-Time Tracking**: A GPS-based vehicle monitoring system that will display the actual position of each vehicle on the network map with continuously updated arrival predictions. This feature will significantly improve user confidence by providing accurate waiting times and reducing uncertainty during travel planning.

- **Mobile Application**: Native applications for Android and iOS platforms that will provide optimized mobile access to all system features, including offline capabilities, push notifications for service disruptions, and location-aware suggestions. The applications will integrate with device features such as calendar and navigation to offer a seamless mobility experience.

- **Service Expansion**: Extension of the platform to incorporate additional transportation modes including regional trains, intercity buses, bike-sharing systems, and on-demand transport services. This multi-modal approach will create a comprehensive mobility solution for the entire region rather than just the city itself.
