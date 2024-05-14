using Domen;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Communication
    {
        Socket socket;
        CommunicationHelper helper;
        public void Connect()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);
                helper = new CommunicationHelper(socket);
            }
            catch (SocketException ex)
            {
                Debug.WriteLine("<<<" + ex.Message);
                throw;
            }
           
        }
        private void SendRequest(Operation operation, object requestObject = null)
        {
            try
            {
                Request request = new Request
                {
                    Operation = operation,
                    RequestObject = requestObject
                };
                helper.Send(request);
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }

        }
        public object Login(Korisnik user)
        {
            SendRequest(Operation.PrijavaKorisnika, user);
            return (Korisnik)GetResult();

        }
        public Institucija LoginAdmin(Institucija user)
        {
            SendRequest(Operation.PrijaviSe, user);
            return (Institucija)GetResult();
        }
        private object GetResult()
        {
            Response response = helper.Receive<Response>();
            if (response.isSuccessful)
            {
                return response.Result;
            }
            else
            {
                Debug.Write(response.Message);
                return null;
            }

        }
        public Korisnik Register(Korisnik user)
        {
            SendRequest(Operation.RegistrujKorisnika, user);
            return (Korisnik)GetResult();
        }
        public Izlozba KreirajIzlozbu(Izlozba izlozba)
        {
            SendRequest(Operation.KreirajIzlozbu, izlozba);
            return (Izlozba)GetResult();
        }
        public List<Izlozba> GetIzlozbe()
        {
            SendRequest(Operation.UcitajListuIzlozbi);
            return (List<Izlozba>)GetResult();
        }
        public List<Markica> GetMakrice()
        {
            SendRequest(Operation.UcitajListuMarkica);
            return (List<Markica>)GetResult();
        }
        public List<Izlozba> GetIzlozbePlus()
        {
            SendRequest(Operation.UcitajListuIzlozbiPlus);
            return (List<Izlozba>)GetResult();
        }
        public List<Kategorija> GetKategorija()
        {
            SendRequest(Operation.UcitajListuKategorija);
            return (List<Kategorija>)GetResult();
        }
        public Rezervacija KreirajRezervaciju(Rezervacija rezervacija)
        {
            SendRequest(Operation.KreirajRezervaciju, rezervacija);
            return (Rezervacija)GetResult();
        }
        public Markica KreirajMarkicu(Markica markica)
        {
            SendRequest(Operation.KreirajMarkicu, markica);
            return (Markica)GetResult();
        }
        public Markica IzmeniMarkicu(Markica markica)
        {
            SendRequest(Operation.IzmeniMarkicu, markica);
            return (Markica)GetResult();
        }
        public List<Rezervacija> GetRezervacije(Korisnik korisnik)
        {
            SendRequest(Operation.UcitajListuRezervacija, korisnik);
            return (List<Rezervacija>)GetResult();
        }
        public Rezervacija ObrisiRezervaciju(Rezervacija trazena)
        {
            SendRequest(Operation.ObrisiRezervaciju, trazena);
            return (Rezervacija)GetResult();
        }
        public void Close(Korisnik prijavljeniKorisnik)
        {
            try
            {
                SendRequest(Operation.OdjaviKorisnika, prijavljeniKorisnik);
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            finally
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                socket = null;
            }
        }
        public void Close(Institucija prijavljenaInstitucija)
        {
            try
            {
                SendRequest(Operation.OdjaviInstituciju, prijavljenaInstitucija);
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            finally
            {
                socket?.Close();
                socket = null;
            }
        }
        public List<Markica> PretraziMarkice(string pretraga)
        {
            SendRequest(Operation.NadjiMarkice, pretraga);
            return (List<Markica>)GetResult();
        }
        public List<Izlozba> PretraziIzlozbe(string pretraga)
        {
            SendRequest(Operation.NadjiIzlozbe, pretraga);
            return (List<Izlozba>)GetResult();
        }
        public List<Kolekcija> GetKolekcija(Korisnik prijavljeniKorisnik)
        {
            SendRequest(Operation.UcitajKolekciju, prijavljeniKorisnik);
            return (List<Kolekcija>)GetResult();
        }

        public object UbaciUKolekciju(Kolekcija trazena)
        {
            SendRequest(Operation.UbaciUKolekciju, trazena);
            return (Kolekcija)GetResult();
        }

        public object IzbaciIzKolekcije(Kolekcija markica)
        {
            SendRequest(Operation.IzbaciIzKolekcije, markica);
            return (Kolekcija)GetResult();
        }
    }
}
