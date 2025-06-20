# Aplikace API_FORM(práce z API daty ze Zásilkovny)

# Popis

Aplikace načítá z dostupných dat Zásilkovny - viz. [Link](https://www.zasilkovna.cz/api/v3/41494564a70d6de6/branch.json) 

## Popis funkcí

**Menu**

* Aktualizuj Data Zasilkovna
* Vyhledej Zasilkovnu

Aktualizace dat Načte data z linku ze Zasilkovny. Tato data nejsou určená pro čtení ze C#, protože data nerozlišují prázdný řetězec od prázdného objektu. Proto v programu je provedeno několik úprav při zpracování dat, které tento problém řeší.

Vyhledávání řetězce umožňuje hledat data pomocí jednoho z cca 15-20 polí. Pro řetězce vyhledává pomocí LIKE a nerozlišuje diakritiku. (pro ZIP kód je třeba psát řetězec ve formátu "111 11" (mezera) - to bych asi měl upravit).

**Úpravy položek**

Umožňuje upravit libovolná pole (nebo přidat pole pro linky na fotky a doby kdy je zásilkovna zavřená).
"Zobraz na mapě" ukáže pozici na mapě z řetězce latitude a longitude componenty. Umožnuje zobrazení v google mapách v prohlížeči nebo pomocí rozšíření Leaflet přímo v programu(javascript).

## DB diagram:
![MainDB](images/db_diagram.jpg)

//TODO - doplnit

### Poznámky

- pořád ve vývoji. 

### TODO

- UPDATE a DELETE celých zásilkoven.