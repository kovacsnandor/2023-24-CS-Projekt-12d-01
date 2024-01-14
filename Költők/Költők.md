# Költők szóstatisztikája
Hasonlítsa össze három magyar költő: `Arany János`, `Petőfi Sándor`, `Ady Endre` szóhasználatát.

## A feladat részletezése
### 1. Adatgyűjtés
Töltse le a három költő összes költeményét `txt formában`.
- `Költemények Arany János.txt`
- `Költemények Petőfi Sándor.txt`
- `Költemények Ady Endre.txt`

### 2. Kigyűjtendő adatok
A program költőnként 
- olvassa be a köteteket egy szöveges változóba, majd 
- szedje szét szavakra. A szavak között ne szerepeljenek az elemzés szempontjából felesleges karakterek, szavak:
    - szóközök, sorvége jelek
    - írásjelek (. , : ? - ; stb.), 
    - kötőszók (a, az, azt, e, és, vagy, hogy stb.)

- Készítse el a `szókészlet szótárukat` két oszlopban szavak szerint abc rendben egy-egy fájlba:
    - 1\. oszlop: a szó
    - 2\. oszlop: hányszor 
    - A fájlok:
        - Szókészlet szótár Arany János.txt
        - Szókészlet szótár Petőfi Sándor.txt
        - Szókészlet szótár Ady Endre.txt

- Készítse el a `szóstatisztikájukat` két oszlopban előfordulás szerint csökkenő rendben egy-egy fájlba:
    - 1\. oszlop: a szó
    - 2\. oszlop: hányszor 
    - A fájlok:
        - Szóstatisztika Arany János.txt
        - Szóstatisztika Petőfi Sándor.txt
        - Szóstatisztika Ady Endre.txt

- Készítse el a `50 leggyakoribb szavukat` két oszlopban előfordulás szerint csökkenő rendben egy-egy fájlba:
    - 1\. oszlop: a szó
    - 2\. oszlop: hányszor 
    - A fájlok:
        - 50 leggyakoribb szó Arany János.txt
        - 50 leggyakoribb szó Petőfi Sándor.txt
        - 50 leggyakoribb szó Ady Endre.txt

- Végül egy Költők szókészlete.txt fájlba és a képernyőre két oszlopba:
    - 1\. oszlop: Költő neve
    - 2\. oszlop: Hány szót használ
    - Hány szót használ szerint csökkenőben

### 3. Vizualizáció
Az 50 leggyakoribb szó ... fájlok alapján készítse el a költők szófelhőjét valamilyen online alakalmazással, amin szemléletesen megjelenik azok gyakorisága.