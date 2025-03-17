using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PustolovščinaCMD
{
    class Program
    {
         static int zivljenja = 5;
         static bool imaNapoj = false;

        public static void Main(string[] args)
        {
            

            ZacniIgro(1);
        }

        public static void ZacniIgro(int st)
        {
            Console.WriteLine("");
            Console.WriteLine("Dobrodošli v pustolovski igri!");
            Console.WriteLine("Ste Deadpool na iskanju izgubljenega zaklada Indiane Jonesa :o");
            Console.WriteLine($"Imate {zivljenja} življenj");
            Console.WriteLine("");
            Console.WriteLine("Trenutno hodite po tropskem deževnem gozdu na otoku Fatu Hiva, ");
            Console.WriteLine("ura je petnajst čez poldan, po svojem telesu čutite nabrano vlago pragozda, v svojih rdečih pajkicah vam postaja vedno bolj nelagodno, čimičange prejšnjega večera pa se vam vedno bolj zdijo kot slaba odločitev.\nNa poti pridete do razcepa. Ustavite se, snamete si klobuk (zelo cool klobuk) in si obrišete pot s čela (imate masko, celi ste v pajkicah, ampak nek skript mora biti).\n 'Katera smer je prava? Od te vročine sem malce izgubil orientacijo..čimičange tudi ne pomagajo'");
            Console.WriteLine("Vnesite 'levo', če želite iti levo, ali 'desno', če želite iti desno.");
            Console.WriteLine("");
            

            string izbira = Console.ReadLine().ToLower();

            if (izbira == "levo")
            {
                LevaPot(1);
            }
            else if (izbira == "desno")
            {
                DesnaPot();
            }
            else
            {
                if (st > 0)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Neveljavna izbira. Poskusite znova.");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("");
                    ZacniIgro(st - 1);

                }
                else if (st == 0)
                {
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Hey, sugarpie, sweetcheeks. Vidim, da se mučiš z branjem. Sej vem, sej vem, vse je enkrat prvič.. LEVO ali DESNO!?\nPrvi level for fucks sake.");
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
                    ZacniIgro(-1);
                }
                //še ena verzija
                else if(st<0)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("-.- ... Kaj je narobe s tabo?");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("");
                    ZacniIgro(1);
                }
            }
        }

        public static void LevaPot(int st)
            
        {
           
            Console.WriteLine("Zavijete levo in naletite na sumljivo prijaznega, nič slutečega domorodca. Preverite situacijo, zdi se vam v redu,\nzato vprašate za pomoč in mu poveste, da ste namenjeni do gore 'Mount doom'.\nNa srečo znate osnove lokalnega jezika (how convinient >.-), pa tudi ubiti vas ni želel (bonus), tako da skrbno poslušate človeka :).");
            Console.WriteLine("Pove vam za bližnjico, ter različne napotke in nevarnosti, ampak ker je govoril veliko v narečnih besedah ga niste čisto vsega razumeli, vendar se vseeno odpravite na pot.\nPo tridesetih minutah hoje pridete do deroče reke. Spomnite se, da vam je domorodec omenil reko in kaj naj bi naredili, ko pridete do nje. Ker pa ga niste razumeli čisto vsega ste ta trenutek praktično skoraj brez njegove pomoči.\nPomislite in pridete do ugotovitve, da vam ostaneta le dve najbolj logični rešitvi:\nLahko bi jo poiskusili preskočiti!\nAli pa manj zabavno možnost: da greste ob reki v eno smer, v upanju da najdete most ozirama kakršnokoli možnost prečkanja. (buuuuuuu)");
            Console.WriteLine("Veš da hočeš ('skoči') ...*khm*pussy ('upanje')?");
            Console.WriteLine("");

            string izbira = Console.ReadLine().ToLower();
            if (izbira == "skoci")
            {
                st = 1;
                        Console.WriteLine("Skočite čez reko, a zdrsnete in izgubite življenje! ('a nismo nesmrtni?' 'ja, ampak tako delujejo igrice' 'Lameee'\nPrišli ste nazaj na začetno stran brega.");

                        Console.WriteLine("");
                        IzgubiZivljenje();
                        Console.WriteLine("");

                //izbira
                        Console.WriteLine("Ali jo boste poiskušali preplavati B) ('plavaj' (priporočen prehod z 2 življenji ali več) ) ali poiskati drugo pot ('pot')?");
                        Console.WriteLine("");
                
                        string drugaIzbira = Console.ReadLine().ToLower();

                        if (drugaIzbira == "plavaj")
                        {
                     int zivljenja = 3;
                            Console.WriteLine("Tok vas odnese, a se rešite. Izgubili ste še eno življenje!");

                            Console.WriteLine("");
                            IzgubiZivljenje();
                            Console.WriteLine("");

                            Console.WriteLine("Skobacate se na vrh druge strani brega");
                            Console.WriteLine("Kljub zlomljeni roki, skupaj z zapestjem, in prstih na njej se počutite epsko kot še nikoli prej ('Laž. Velikokrat sem se počutil še bolj epsko kot se zdaj') ");
                            Console.WriteLine("'Kaj pa bo z roko??' 'Relaxx. Regenerativne sposobnosti? Deadpool. Se spomniš?'");
                            Console.WriteLine("Bolj podrobno pogledate okrog sebe in zagledate pot skozi gozd. Zadaj v daljavi, onkraj gozda, stoji velikanska gora (*globok, hrapajoč glas* 'Mount doooom!'), sklepate da pot vodi tja.");
                            Console.WriteLine("Krenete na pot.");
                            Console.WriteLine("Dvajset metrov po poti noter v gozd vas napade medved.\nKer ste še vedno poškodovani ('Sorry ampak regeneracija ne deluje tako hitro') se vam je nekoliko težje boriti z njim, zato vas kljub svojim super mega sposobnostim, supermoči, ne ene temveč dveh katan in dveh Beretta 92FS devetmilimeterskih pištol vseeno ubije. 'Loser' ");
                            KonecIgre("");
                        }

                        else if (drugaIzbira == "pot")
                        {
                                        upanje(1);
                        }
                        else
                        {
                            if (st > 0)
                            {
                                Console.WriteLine("------------------------------------------------------------------");
                                Console.WriteLine("Neveljavna izbira. Poskusite znova. ('zbijam življenja. BERI') ");
                                Console.WriteLine("------------------------------------------------------------------");
                                Console.WriteLine("");
                                LevaPot(st-1);
                                
                            }
                            if (st == 0)
                            {
                                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("'*sigh* še vedno isto huh?  B E R I. Zdej greš vse od razcepa še enkrat + še eno življenje sem si/ti ah sej stekas, -1life '");
                                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("");
                                LevaPot(-1);
                               

                            }
                            else if (st < 0)
                            {
                                Console.WriteLine("-------------------------------------");
                                Console.WriteLine("'Okej zdej greš VSE še enkrat'");
                                Console.WriteLine("-------------------------------------");
                                Console.WriteLine("");
                                ZacniIgro(3);
                                st = 1;
                                
                            }
                
                        }
            }
            else if (izbira == "upanje")
            {
                
                Console.WriteLine("");
                Console.WriteLine("Po dveh dolgih, dolgočasnih in na vrh še vročih urah hoje ob reki navzgor zagledate star kamniti most, skoraj ves prekrit v mahu, ki je napeljan čez reko.");

                //izbira
                Console.WriteLine("Greste pogledat pod most ('firbec') ? Ali greste naprej čez most, proti gori ('naprej') ?");
                Console.WriteLine("");
                string drugaIzbiraa = Console.ReadLine().ToLower();


                if (drugaIzbiraa == "firbec")
                {
                    Console.WriteLine("Iz radovednosti greste pogledati pod most, kjer zagledate vrata v steni (*gasp* 'za temi vrati je potencialno leteči samorog s tetovažami in mitraljezom, ki bo lahko moj prijatel za vedno. Zakon!')");
                    Console.WriteLine("Pred vrati se nenadoma pojavi pravi orjaški trol, ki bo storil KARKOLI, da vas ne spusti skozi vrata.'...hehe je reku karko- NE. Vem kaj razmišljaš. Umiri se'");
                    Console.WriteLine("Želite ubiti trola ('ubij') ali odditi drugam in za vedno obžalovati da niste odprlih tistih vrat? ('depresija').");
                    Console.WriteLine("");
                    string odgovor = Console.ReadLine().ToLower();
                    Console.WriteLine("Deadpool je od vzhičenosti že ubil trola in pravkar končal postavljati dva kilograma C4 eksploziva na vrata.");
                    Console.WriteLine("'Ka-boom' *click*");
                    Console.WriteLine("BOOOOOOOOOOOOOOMM!!!");
                    Console.WriteLine("");

                    if (odgovor == "depresija")
                    {
                        Console.WriteLine("PS: You are sick");
                        Console.WriteLine("");
                        Console.WriteLine("Prišli ste v prej zaklenjen, zdaj na široko odprt, prostor (kar ga je še ostalo, na srečo je bil velik). Prav na koncu, še preostale, sto meterske, temne, že več desetlet zaprte sobe zagledate bežno svetlobo ('samorog z mitraljezom!') in zdrvite proti tja");
                        Console.WriteLine("");
                        KonecIgre("Dobili ste staro skrinjo brez ključavnice, polno zlatnikov in draguljev!\n'Ah brezveze... ma tudi tega se ne bom branu $P'");
                    }
                    else
                    {
                        Console.WriteLine("Prišli ste v prej zaklenjen, zdaj na široko odprt, prostor (kar ga je še ostalo, na srečo je bil velik). Prav na koncu, še preostale, sto meterske, temne, že več desetlet zaprte sobe zagledate bežno svetlobo ('samorog z mitraljezom!') in zdrvite proti tja");
                        Console.WriteLine("");
                        KonecIgre("Dobili ste staro skrinjo brez ključavnice, polno zlatnikov in draguljev!\n'Ah brezveze... ma tudi tega se ne bom branu $P'");

                    }
                }
                else if (drugaIzbiraa == "naprej")
                {

                    Console.WriteLine("Greste naprej po poti in pridete do vzpona na goro.");
                    Console.WriteLine("Po mučnih urah hoje in plezanja na goro, končno pridete do vrha kjer se nahaja tempel.");
                    Console.WriteLine("Ta tempel je v resnici bar.");
                    KonecIgre("Zmagali ste! Poglejte ta razgled zdraven kafeta!");

                }
                else
                {
                    if (st > 0)
                    {
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Neveljavna izbira. Poskusite znova.");
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("");
                        upanje(1);
                    }
                    if (st == 0)
                    {
                        Console.WriteLine("-------------------------------------------------------------------------");
                        Console.WriteLine("'*sigh* še vedno isto huh?  B E R I. Zdej greš vse od razcepa še enkrat'");
                        Console.WriteLine("-------------------------------------------------------------------------");
                        Console.WriteLine("");
                        LevaPot(-1);

                    }
                    else if (st < 0)
                    {
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("'Okej zdej greš VSE še enkrat'");
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("");
                        ZacniIgro(3);
                        st = 1;
                    }
                }

            }
              else
              {
                if (st > 0)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Neveljavna izbira. Poskusite znova.");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("");
                    LevaPot(st - 1);
                }
                if (st == 0)
                {
                    Console.WriteLine("-------------------------------------------------------------------------");
                    Console.WriteLine("'*sigh* še vedno isto huh?  B E R I. Zdej greš vse od razcepa še enkrat'");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    Console.WriteLine("");
                    LevaPot(-1);

                }
                else if (st < 0)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("'Okej zdej greš VSE še enkrat'");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("");
                    ZacniIgro(3);
                    st = 1;
                }
              }
        }


        public static void DesnaPot()
        {
            Console.WriteLine("Ubereš pravo pot ('se laže, morali bi  it levo') in naletiš na skrito jamo.");
            Console.WriteLine("Ali želite raziskati jamo ('da') ali nadaljevati pot ('ne')?");

            string izbira = Console.ReadLine().ToLower();
            if (izbira == "da")
            {
                RaziskovanjeJame();
            }
            else if (izbira == "ne")
            {
                Console.WriteLine("Nadaljujete pot in se spotaknete ob korenino. Utrpite poškodbe, ker ste se spotaknili ravno pred prepadom! ('Itak') ");

                Console.WriteLine("");
                IzgubiZivljenje();
                Console.WriteLine("");
                IzgubiZivljenje();
                Console.WriteLine("");

                Console.WriteLine("Ulovili ste se na kamniti polici brezna. Na srečo je nahrbtnik ostal na hrbtu, zato ste lahko poklicali helikopter na pomoč.");
                Console.WriteLine("Najprej ste pogledali okrog in ocenili situacijo. Na vaši levi je bila manjša jama v steni in do nje se je dalo priti.");
                Console.WriteLine("Počasi in previdno ste se premaknili tja. Jama je bila kratka in po izgledu nikoli dotaknjena. Razen s strani ptičev, oni so jo veliko krat uporabljali za wc. ('yuck') ");
                Console.WriteLine("Končno ste se lahko vsedli in poklicali na pomoč. Helikoper ste čakali do sončnega zahoda ob odprti jami, ki je imela odličen pogled nanj. ('Sem vsaj preživel, pa tudi na wc sem lahko šel s takim pogledom pred mano'");
                KonecIgre("ste preživeli, a niste našli zaklada.");
            }
            else
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Neveljavna izbira. Poskusite znova.");
                Console.WriteLine("-------------------------------------");
                DesnaPot();
            }
        }

        public static void RaziskovanjeJame()
        {
            Console.WriteLine("Vstopite v jamo in naletite na pasti! ('ohh bu hu... Immortal. Remember?')");
            IzgubiZivljenje();
            Console.WriteLine("'Wha- kaj?? Aja igrica... lame..'");
            Console.WriteLine("Vendar na tleh zagledate zdravilni napoj. Ali ga boste vzeli? ('da' / 'ne')?");

            string izbira = Console.ReadLine().ToLower();
            if (izbira == "da")
            {
                Console.WriteLine("Vzamete napoj in ga shranite za kasneje!('How convinient!'");
                imaNapoj = true;
            }
            else
            {
                Console.WriteLine("Odločili ste se, da ne boste vzeli napoja.");
            }

            Console.WriteLine("Ko nadaljujete, nenadoma pade skala in vas poškoduje! ('Shocker') Ali boste uporabili napoj ('da') ali tvegali ('ne')?");
            string drugaIzbira = Console.ReadLine().ToLower();
            if (drugaIzbira == "da" && imaNapoj)
            {
                Console.WriteLine($"Uporabite napoj in si povrnete življenje! Življenja:{zivljenja} ('Ha haa. I HAVE the power of this magic relm!!') ");
                zivljenja++;
                imaNapoj = false;
            }
            else
            {
                Console.WriteLine("Tvegali ste in utrpeli še eno poškodbo! ('sm vedu!') ");
                IzgubiZivljenje();
            }

            Console.WriteLine("Počasi nadaljujete in najdete staro skrinjo('hmm. Sumljivo...eh fuck it *creeeek*') ... Odprete jo in notri je zaklad! ('YEAA BABYY!!') ");
            KonecIgre("ste zmagali in našli zaklad!");
        }

       
                                public static void upanje(int st)
                                {
                                    
                                    Console.WriteLine("");
                                    Console.WriteLine("Po dveh dolgih, dolgočasnih in na vrh še vročih urah hoje ob reki navzgor zagledate star kamniti most, skoraj ves prekrit v mahu, ki je napeljan čez reko.");

                                    Console.WriteLine("Greste pogledat pod most ('firbec') ? Ali greste naprej po poti, proti gori ('naprej') ?");
                                    Console.WriteLine("");
                                    string drugaIzbiraa = Console.ReadLine().ToLower();


                                    if (drugaIzbiraa == "firbec")
                                    {
                                        Console.WriteLine("Iz radovednosti greste pogledati pod most, kjer zagledate vrata v steni (*gasp* 'za temi vrati je potencialno leteči samorog s tetovažami in mitraljezom, ki bo lahko moj prijatel za vedno. Zakon!')");
                                        Console.WriteLine("Pred vrati se nenadoma pojavi pravi orjaški trol, ki bo storil KARKOLI, da vas ne spusti skozi vrata.'...hehe je reku karko- NE. Vem kaj razmišljaš. Umiri se'");
                                        Console.WriteLine("Želite ubiti trola ('ubij') ali odditi drugam in za vedno obžalovati da niste odprlih tistih vrat? ('depresija').");
                                        Console.WriteLine("");
                                        string odgovor = Console.ReadLine().ToLower();
                                        Console.WriteLine("Deadpool je od vzhičenosti že ubil trola in pravkar končal postavljati dva kilograma C4 eksploziva na vrata.");
                                        Console.WriteLine("'Ka-boom' *click*");
                                        Console.WriteLine("BOOOOOOOOOOOOOOMM!!!");
                                        Console.WriteLine("");

                                        if (odgovor == "depresija")
                                        {
                                            Console.WriteLine("PS: You are sick");
                                            Console.WriteLine("");
                                            KonecIgre("Dobili ste staro skrinjo brez ključavnice, polno zlatnikov in draguljev!\n'Ah brezveze... ma tudi tega se ne bom branu $P'");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Prišli ste v prej zaklenjen, zdaj na široko odprt, prostor (kar ga je še ostalo, na srečo je bil velik). Prav na koncu, še preostale, sto meterske, temne, že več desetlet zaprte sobe zagledate bežno svetlobo ('samorog z mitraljezom!') in zdrvite proti tja");
                                            Console.WriteLine("");
                                            KonecIgre("Dobili ste staro skrinjo brez ključavnice, polno zlatnikov in draguljev!\n'Ah brezveze... ma tudi tega se ne bom branu $P'");

                                        }
                                    }
                                    else if (drugaIzbiraa == "naprej")
                                    {

                                        Console.WriteLine("Greste naprej po poti in pridete do vzpona na goro.");
                                        Console.WriteLine("Po mučnih urah hoje in plezanja na goro, končno pridete do vrha kjer se nahaja tempel.");
                                        Console.WriteLine("Ta tempel je v resnici bar.");
                                        KonecIgre("Zmagali ste! Poglejte ta razgled zdraven kafeta!");

                                    }
                                    else
                                    {
                                        if (st > 0)
                                        {
                                            Console.WriteLine("-------------------------------------");
                                            Console.WriteLine("Neveljavna izbira. Poskusite znova.");
                                            Console.WriteLine("-------------------------------------");
                                            Console.WriteLine("");
                                            upanje(st-1);
                                        }
                                        if (st == 0)
                                        {
                                            Console.WriteLine("-------------------------------------------------------------------------");
                                            Console.WriteLine("*sigh* še vedno isto huh?  B E R I. Zdej greš vse od razcepa še enkrat");
                                            Console.WriteLine("-------------------------------------------------------------------------");
                                            Console.WriteLine("");
                                            LevaPot(-1);

                                        }
                                        else if (st < 0)
                                        {
                                            Console.WriteLine("-------------------------------------");
                                            Console.WriteLine("Okej zdej greš VSE še enkrat");
                                            Console.WriteLine("-------------------------------------");
                                            Console.WriteLine("");
                                            ZacniIgro(3);
                                            st = 1;
                                        }
                                    }

                                }


        public static void IzgubiZivljenje()
        {
            zivljenja--;
            Console.WriteLine("");
            Console.WriteLine($"Opozorilo: Izgubili ste življenje! Preostala življenja: {zivljenja}");
            Console.WriteLine("");

            if (zivljenja <= 0)
            {
                KonecIgre("Izgubili ste vsa življenja");
            }
        }

        public static void KonecIgre(string rezultat)
        {
            Console.WriteLine("Konec igre! " + rezultat);
            Console.WriteLine("Ali želite igrati znova? (da/ne)");

            string ponovno = Console.ReadLine().ToLower();
            if (ponovno == "da")
            {
                zivljenja = 5;
                imaNapoj = false;
                ZacniIgro(1);
            }
            else
            {
                Console.WriteLine("Hvala za igranje!");
            }
        }
    }
}








