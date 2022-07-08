/* Gebruik de kracht van loops om pijlsnel alle tafels van 1 tot en met 10 van vermenigvuldigen op het scherm te tonen 
(dus van 1×1 tot 10×10 en alles daartussen). */
int tafelVan = 10;
for (int i = 1; i < 11; i++){
    Console.WriteLine($"{i} x {tafelVan} = {i*tafelVan}");
}
