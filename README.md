# NTM

The project is generated to answer the following assignment :

Nyhetssajt

Sammanfattning:
Din uppgift är att skapa en nyhetssajt som tar in nyheter från olika flöden.

Beställning:
Vi vill ha en sajt som levererar oberoende nyheter från olika kanaler. Dessa ska läsas in automatiskt från olika källor. Sajten ska även vara responsiv och kunna användas från desktop, surfplatta och mobil.

Startsidan:
Denna sidan ska visa nyhetspuffar från alla registrerade källor, sorterat på datum.
Undersida
Varje källa ska ha en undersida där enbart källans nyheter visas. Sorteras på datum. Här ska även info om källan finnas.

Design:
Ingen fokus kommer ligga på designen. Så designen gör du som du vill. Sidan måste ha följande:

• Header
  ◦ Meny med de olika källorna.

• Footer
  ◦ Skapad av…
  
Nyhetspuffarna måste innehålla följande:
• Titel
• Bild, om finns
• Text
• Publiceringsdatum
• Kategori, om finns 
• Länk till nyheten som öppnas i nytt fönster
• Källa	

Ramverk:
De enda kraven är att du använder:
    • Angular
    • ASP.Net C# (WebApi, MVC eller .Net Core. Du väljer själv).

Dokumentation:
Projektet ska vara dokumenterat i kod.

Extra :
Om du hinner eller vill prestera lite extra så kan du göra följande:
    • När man klickar på en kategori så kommer man till en samlingssida för den kategorin.
    • En adminsida där man kan lägga till nya källor.
    • Öka snabbheten på sajten genom att lägga till cache hantering eller liknande.
    • Gör sajten SEO vänlig.
    • Unit tester på både front och back-end.
    • Dokumentera projektet i eget dokument.
    
RSS flöden:

• https://www.nt.se/rss/lokalt/norrkoping

• https://feeds.expressen.se/nyheter/

• https://www.svd.se/?service=rss
    
    
    What The project does :
    The Project is MVC and works with Framework .NET 4.5.2 . It Reads RSS from the three mentioned links and shows them in the page described as above.
    From Extras :
        • När man klickar på en kategori så kommer man till en samlingssida för den kategorin.
        It does show the news by category if you click on it but only from svd.
        • En adminsida där man kan lägga till nya källor.
        This Extra in my opinion requires the implementation of either database or using XML files, but I decided not to use file or database to make the code runnable in different computers.
        I thought it would be more convenient if I don't use a database in this stage, although  I know how to do it.
        • Öka snabbheten på sajten genom att lägga till cache hantering eller liknande.
        Not done but I have some ideas about it.
        • Gör sajten SEO vänlig.
        Not done
        • Unit tester på både front och back-end.
        Not done
        • Dokumentera projektet i eget dokument.
        Not done
        


    
    
