
<h1>A program lényege, céljai</h1>
<p>Egy olyan programot szeretnék készíteni, amely segítségével egy vállalkozás/üzlet/gyár stb. készleteit tudjuk nyilvántartani, ezzel megkönnyítve a munkát.</p>

<h2>Alapvető főbb funkciók</h2>
<ul>
    <li>Többfelhasználós, bejelentkezős rendszer, admin és alap jogosultságokra bontva</li>
    <li>Központi MySQL adatbázissal kommunikál, ott tárolja az adatokat</li>
    <li>Termékeket tudunk rögzíteni (mennyiség, cikkszám, stb...), szerkeszteni, törölni, exportálni excelbe vagy CSV fájlba</li>
    <li>Áru beszállítások rögzítése, exportálása, ezek esetleges javítása</li>
    <li>Hiányzó áruk rögzítése, ezek esetleges javítása</li>
    <li>A listanézetekben szűrés, rendezés</li>
    <li>Saját levelező rendszer, üzenetküldés a dolgozók között</li>
    <li>Dolgozók listájának megtekintése, exportálása, admin jogokkal való szerkesztése</li>
</ul>

<h2>Rendszerkövetelmények, illetve technikai adatok</h2>
<ul>
    <li>A program C#-ban íródott</li>
    <li>Windows 7 és annál újabb operációs rendszer</li>
    <li>.NET keretrendszer (A program telepítője ezt is fel fogja telepíteni)</li>
    <li>Internetkapcsolat szükséges, hacsak nem egy helyi hálózaton fut az adatbázis</li>
    <li>Az adatbázis futhat egy szervergépről, de akár fel is lehet építeni egy script lefuttatásával</li>
    <li>Lehetőség van a programon belül az adatbázis kapcsolatot beállítani egy mesterjelszó ismeretének segítségével</li>
    <li>A program bezárása után automatikusan kijelentkezünk, minden indulásnál be kell lépni</li>
    <li>A jelszavak természetesen titkosítva kerülnek az adatbázisba</li>
</ul>

<h2>További tervek</h2>
<ul>
    <li>A számvitel törvényeinek megfelelő nyilvántartás a termékekre vonatkozóan</li>
    <li>Leltárív, Jegyzőkönyv nyomtatás</li>
    <li>Segítség/help funkció a menükben</li>
    <li>A beszállítások jelenleg úgy működnek, hogy egyszerre csak egyféle terméket enged rögzíteni, így egy beszállítás során (ugyanazzal a fuvarszámmal) annyiszor kell ismételni, ahány termék van. Ezt igyekszem majd javítani.</li>
</ul>

<img src="https://github.com/krisztiankarolyi/Sapi_WareHouse/assets/145534392/5ca0177c-37eb-43db-a34c-85327d0f1915">
<img src="https://github.com/krisztiankarolyi/Sapi_WareHouse/assets/145534392/f68008e5-f2cb-4254-a3bf-3364100b124f"> 


