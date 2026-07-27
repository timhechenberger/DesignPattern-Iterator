# Design Pattern: Iterator

Beispielimplementierung des **Iterator-Patterns** in C# (.NET 8) anhand einer Musik-Playlist.

## Idee des Patterns

Das Iterator-Pattern erlaubt es, die Elemente einer Sammlung nacheinander zu durchlaufen,
**ohne** deren interne Struktur (hier: eine `List<string>`) nach außen preiszugeben.
Der aufrufende Code kennt nur die beiden Methoden `hasNext()` und `next()` — ob dahinter
eine Liste, ein Array oder eine Datenbank steckt, ist für ihn egal.

## Aufbau

| Datei | Rolle im Pattern | Beschreibung |
| --- | --- | --- |
| [Iterator.cs](Iterator.cs) | `Iterator` (Interface) | Definiert `hasNext()` und `next()`. |
| [PlaylistIterator.cs](PlaylistIterator.cs) | `ConcreteIterator` | Konkrete Implementierung für eine Playlist, merkt sich die aktuelle Position. |
| [Program.cs](Program.cs) | `Client` | Erzeugt die Playlist und durchläuft sie mit dem Iterator. |

### Ablauf

1. `PlaylistIterator` bekommt im Konstruktor die Playlist übergeben und setzt `_currentIndex` auf `0`.
2. `hasNext()` prüft, ob `_currentIndex` noch innerhalb der Liste liegt.
3. `next()` liefert das aktuelle Element und erhöht `_currentIndex` um `1`.
   Ist kein Element mehr vorhanden, wird `null` zurückgegeben.

## Verwendung

```csharp
List<string> playlist = new List<string>();
playlist.Add("StarBoy");
playlist.Add("Nirvana");

PlaylistIterator playlistIterator = new PlaylistIterator(playlist);
while (playlistIterator.hasNext())
{
    Console.WriteLine(playlistIterator.next());
}
```

## Ausführen

```bash
dotnet run --project DesignPattern-Iterator.csproj
```

### Ausgabe

```
StarBoy
Bibabuzelmann
Nirvana
Foofigthers
ACDC
```

## Voraussetzungen

- .NET 8 SDK
