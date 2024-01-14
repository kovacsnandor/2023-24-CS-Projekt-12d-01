# Véletlen könyvtár
Tervezzen egy általános véletlen generátor DLL könyvtárat, amit egy statikus osztállyal valósít meg, és ennek a metódusai szolgálnak ki.

Az alábbiakban nagyvonalakban felvázoljuk, hogy mire gondolunk, de ezt módosíthatja, bővítheti.

Az elkészült DLL-t tesztelnie kell az ön által kigondolt minta projektekkel, amihez teljes szabad kezet kap.

## Általános előírások a véletlen könyvtárra

### Elnevezés rendszer
Gondoljon arra, hogy DLL-jét mások is használni fogják, így
- Minden elnevezése `angolul` legyen.
- Az elnevezések fejezzék ki azt, amit csinálnak.
- Használja az úgynevezett `puputeve` (Az egész egybeírva, résszavak nagybetűvel) elnevezés típust egységesen.
- Következetesen:
    - Osztálynév: nagybetűvel kezdődik
    - Metódusnév: Nagybetűvel kezdődik
    - változók, gyűjtemények: kisbetűvel kezdődik

### Help
Az elkészített metódusokhoz precíz, angol nyelvű leírást kell készítenie a c#-ban megszokott /// jel segítségével.
Ne feledje kipipálni a projekt tulajdonságablakában a `Build/Xml documentation file` jelölőnégyzetet.

### Túlterhelt metódusok
Amennyi ben egy metódust többféleképpen akar használni, lehetőleg túlterheléssel oldja meg a paraméterek variálásával.

## Javaslatok a véletlen metódusokra, paramétrekere
### Nyelvek
A feladatot két nyelvre kell elkészíteni.
- Angol
- Magyar
- Ezek az osztály egy kívülről elérhető változóján keresztül legyenek beállíthatóak. 
    - Legyen egy alapértelmezett nyelv.
    - A nyelvekhez megfelelő szám és dátum formák tartozzanak.
- A program saját szöveges forrásokat használjon (névtár, szótár)    

### Javaslatok metódusokra
- Véletlen szó, szólista (lehet ismétlés, nem lehet ismétlés)
- Véletlen mondat
    - paraméterezhetően hány szóból álljon
- Véletlen bekezdés
    - paraméterezhetően: hány mondat, mondatonként hány szó, esetleg tól-ig véletlenszerűen.    
- Véletlen dátum:
    - paraméter nélkül akármi
    - adott évben
    - adott tól-ig évben
    - adott dátumok között
    - adott hónapban
    - stb.
- Véletlen nevek
    - Véletlen (célszerűen külön függvénnyel) vezetéknév, keresztnév  (női, férfi)         
    - lista, lehet ismétlés nem lehet ismétlés
    - Véletlen név, nevek, női férfi stb.
- Véletlen ételek
    - paraméterezhetően: leves, főétel, desszert, ital    
- Véletlen szám:
    - egész, tizedes, tól-ig, lista, lehet ismétlés, adott tartományban
- Véletlen városok (város, lista)
    - Angol esetben angol vagy amerikai városok
    - Magyar esetben minden magyar település

## Javaslatok a forrásokra
- Véletlen szöveghez szótár: Keressünk egy regényt txt formában, szótárazzuk ki a szavait.
- Véletlen nevek: Az interneten nézzünk névgyűjteményeket.

## Javaslat teszt projetkere
### Nevek, ételek:
- Egy elképzelt projetkhez x db város közel 1 000 000 résztvevők objektumlista legenerálása: név, anyja, született, lakhely, foglalkozás

- Van egy embertömeg, amiből kisorsolunk 3 nyertest.

- Véletlen reggelik ebédek vacsorák generálása egy hónapra.

### Szöveg
Szöveg elemzéshez sok különböző méretű txt szövegfájl generálása.

### Számok
- Nagy méretű számlista generálása sorbarendező algoritmusok teszteléséhez.
- Lottószámok generálása








