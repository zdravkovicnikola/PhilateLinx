using Common;
using Domen;
using Logika;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;

namespace ServerskiDeo
{
    internal class ClientHandler
    {
        CommunicationHelper helper;
        Socket klijent;
        public ClientHandler(Socket socket)
        {
            klijent = socket;
            this.helper = new CommunicationHelper(socket);

        }

        public void Close()
        {
            klijent?.Close();
            klijent = null;
        }
        bool kraj = false;
        internal void HandleRequest()
        {
            try
            {
                while (!kraj)
                {
                    Request request = helper.Receive<Request>();
                    Response response = CreateResponse(request);
                    helper.Send(response);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            finally
            {
                SocketClose();
            }
        }

        private Response CreateResponse(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    case Operation.PrijavaKorisnika:
                        response.Result = Kontroler.Instance.PrijaviKorisnika((Korisnik)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Korisnik ne postoji!";
                            break;
                        }
                        break;
                    case Operation.PrijaviSe:
                        response.Result = Kontroler.Instance.PrijaviInstituciju((Institucija)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Trazena institucija nije nadjena!";
                            break;

                        }
                        break;
                    case Operation.RegistrujKorisnika:
                        response.Result = Kontroler.Instance.RegistrujKorisnika((Korisnik)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Korisnik vec postoji, ulogujte se!";
                            break;
                        }
                        break;
                    case Operation.KreirajIzlozbu:
                        response.Result = Kontroler.Instance.KreirajIzlozbu((Izlozba)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Prikazana izlozba vec postoji u bazi!";
                            break;
                        }
                        break;
                    case Operation.UcitajListuIzlozbi:
                        response.Result = Kontroler.Instance.GetIzlozba();
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Nema liste izlozbi u bazi!";
                            break;
                        }
                        break;
                    case Operation.KreirajRezervaciju:
                        response.Result = Kontroler.Instance.KreirajRezervaciju((Rezervacija)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Nije moguce kreirati rezervaciju u bazi!";
                            break;
                        }
                        break;
                    case Operation.UcitajListuRezervacija:
                        response.Result = Kontroler.Instance.GetRezervacija((Korisnik)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Nema liste rezervacija u bazi!";
                            break;
                        }
                        break;
                    case Operation.ObrisiRezervaciju:
                        response.Result = Kontroler.Instance.ObrisiRezervaciju((Rezervacija)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Nije moguce obrisati rezervaciju u bazi!";
                            break;
                        }
                        break;
                    case Operation.UcitajListuKategorija:
                        response.Result = Kontroler.Instance.GetKategorija();
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Nema liste kategorija u bazi!";
                            break;
                        }
                        break;
                    case Operation.OdjaviKorisnika:
                        Kontroler.Instance.OdjaviKorisnika((Korisnik)request.RequestObject);
                        kraj = true;
                        break;
                    case Operation.OdjaviInstituciju:
                        Kontroler.Instance.OdjaviInstituciju((Institucija)request.RequestObject);
                        kraj = true;
                        break;
                    case Operation.UcitajListuMarkica:
                        response.Result = Kontroler.Instance.GetMarkica();
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Nema markica u bazi!";
                            break;
                        }
                        break;
                    case Operation.KreirajMarkicu:
                        response.Result = Kontroler.Instance.KreirajMarkicu((Markica)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Prikazana markica vec postoji u bazi!";
                            break;
                        }
                        break;
                    case Operation.IzmeniMarkicu:
                        response.Result = Kontroler.Instance.IzmeniMarkicu((Markica)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Prikazanu markicu nije moguce izmeniti u bazi!";
                            break;
                        }
                        break;
                    case Operation.NadjiMarkice:
                        response.Result = Kontroler.Instance.NadjiMarkice((string)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Ne postoji markica u bazi!";
                            break;
                        }
                        break;
                    case Operation.NadjiIzlozbe:
                        response.Result = Kontroler.Instance.NadjiIzlozbe((string)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Ne postoji izlozba u bazi!";
                            break;
                        }
                        break;
                    case Operation.UcitajListuIzlozbiPlus:
                        response.Result = Kontroler.Instance.GetIzlozbaPlus();
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Nema liste izlozbi u bazi!";
                            break;
                        }
                        break;
                    case Operation.UcitajKolekciju:
                        response.Result = Kontroler.Instance.GetKolekcija((Korisnik)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Nema markica u kategoriji!";
                            break;
                        }
                        break;
                    case Operation.UbaciUKolekciju:
                        response.Result = Kontroler.Instance.UbaciUKolekciju((Kolekcija)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Nema markica u kategoriji!";
                            break;
                        }
                        break;
                    case Operation.IzbaciIzKolekcije:
                        response.Result = Kontroler.Instance.IzbaciIzKolekcije((Kolekcija)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Nije moguce obrisati rezervaciju u bazi!";
                            break;
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                response.isSuccessful = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public void SocketClose()
        {
            if (klijent != null)
            {
                kraj = true;
                klijent.Shutdown(SocketShutdown.Both);
                klijent.Close();
                klijent = null;
            }
        }
    }
}