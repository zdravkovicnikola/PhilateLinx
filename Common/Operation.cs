namespace Common
{
    public enum Operation //za svaku sistemsku operaciju
                          //treba da postoji jedna stavka enuma
    {
        PrijaviSe, // INSTITUCIJA - ODRADJENO
        RegistrujKorisnika, // KORISNIK - ODRADJENO
        KreirajIzlozbu, // KORISNIK-ODRADJENO
        UcitajKolekciju, 
        UcitajListuMarkica, // KORISNIK - ODRADJENO
        UcitajKategoriju,
        KreirajMarkicu,
        NadjiMarkice,
        IzmeniMarkicu,
        ZapamtiMarkicu, 
        PrijavaKorisnika, // KORISNIK - ODRADJENO
        UcitajListuIzlozbi, // KORISNIK - ODRADJENO
        KreirajRezervaciju, // KORISNIK - ODRADJENO
        UcitajListuKategorija,
        UcitajListuRezervacija,// KORISNIK - ODRADJENO
        ObrisiRezervaciju,// KORISNIK - ODRADJENO
        OdjaviKorisnika, //  KORISNIK - ODRADJENO
        OdjaviInstituciju,
        UcitajListuIzlozbiPlus,
        NadjiIzlozbe,
        UbaciUKolekciju,
        IzbaciIzKolekcije
    }
}
