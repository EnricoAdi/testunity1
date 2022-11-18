public class global 
{
    string judul;
    string deskripsi;
    string gambar;

    public global(string paramJudul, string paramDeskirpsi, string paramGambar)
    {
        judul = paramJudul;
        deskripsi = paramDeskirpsi;
        gambar = paramGambar;
    }

    public string getJudul()
    {
        return judul;
    }

    public string getDeskripsi()
    {
        return deskripsi;
    }

    public string getGambar()
    {
        return gambar;
    }


}
