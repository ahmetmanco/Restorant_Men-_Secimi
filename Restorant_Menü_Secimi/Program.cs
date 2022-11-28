double hesap = 0;
do
{
    Console.Write("1- Yemekler\n2- İçecekler\n3- Tatlılar\n4- Hesap\nLütfen sipariş vereceğiniz seçimi yapınız : ");
    int secim = Convert.ToInt32(Console.ReadLine());
    do
    {
        Console.Write("1- Yemekler\n2- İçecekler\n3- Tatlılar\n4- Hesap\nLütfen sipariş vereceğiniz seçimi yapınız : ");
        secim = Convert.ToInt32(Console.ReadLine());
        if (secim == 1)
        {
            Console.WriteLine("1- Adana Kebap  = 40 ₺\n2- Urfa Kebap  = 35 ₺\n3- Patatesli Köfte Menü  =  20 ₺\n4- Kuru Fasülye + Pilav + Cacık + Salata  =  25 ₺\nLütfen sipariş seçimi yapınız : ");
            secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    hesap += 40;
                    Console.WriteLine("Güncel tutar : " + hesap);
                    break;
                case 2:
                    hesap += 35;
                    Console.WriteLine("Güncel tutar : " + hesap);
                    break;
                case 3:
                    hesap += 20;
                    Console.WriteLine("Güncel tutar : " + hesap);
                    break;
                case 4:
                    hesap += 25;
                    Console.WriteLine("Güncel tutar : " + hesap);
                    break;
                default:Console.WriteLine("Yanlış tuşa bastınız tekrar deneyiniz !");
                    break;
            }

        }
        else if (secim == 2)
        {
            Console.WriteLine("1- Ayran  = 5 ₺\n2- Kola  = 15 ₺\n3- Maden Suyu  =  10 ₺\n4- Limonata  =  15 ₺\n5- Su  =  5 ₺\nLütfen sipariş seçimi yapınız : ");
            secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    hesap += 5;
                    Console.WriteLine("Güncel tutar : " + hesap);
                    break;
                case 2:
                    hesap += 15;
                    Console.WriteLine("Güncel tutar : " + hesap);
                    break;
                case 3:
                    hesap += 10;
                    Console.WriteLine("Güncel tutar : " + hesap);
                    break;
                case 4:
                    hesap += 15;
                    Console.WriteLine("Güncel tutar : " + hesap);
                    break;
                case 5:
                    hesap += 5;
                    Console.WriteLine("Güncel tutar : " + hesap);
                    break;
                default:Console.WriteLine("Yanlış tuşa bastınız tekrar deneyiniz !");
                    break;
            }
        }
        else if (secim == 3)
        {
            Console.WriteLine("1- Baklava  =  40 ₺\n2- Polka  = 35 ₺\n3- İzmir Bomba  =  20 ₺\n4- Sütlaç  =  10 ₺\n5- Pasta  =  55 ₺\nLütfen sipariş seçimi yapınız : ");
            secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    hesap += 40;
                    Console.WriteLine("Güncel tutar : " + hesap);
                    break;
                case 2:
                    hesap += 35;
                    Console.WriteLine("Güncel tutar : " + hesap);
                    break;
                case 3:
                    hesap += 20;
                    Console.WriteLine("Güncel tutar : " + hesap);
                    break;
                case 4:
                    hesap += 10;
                    Console.WriteLine("Güncel tutar : " + hesap);
                    break;
                case 5:
                    hesap += 55;
                    Console.WriteLine("Güncel tutar : " + hesap);
                    break;
                default:
                    break;
            }
        }
        else if (secim == 4)
        {
            hesap += 0;
            Console.WriteLine("Sipariş tutarınız : " + hesap);
        }
        else
        {
            Console.WriteLine("Yanlış secim yaptınız lütfen tekrar deneyiniz ! ");
        }

    } while (secim != 1 || secim != 2 || secim != 3 || secim != 4);



    Console.Write("Tekrar sipariş vermek istiyorsanız kütfen 'evet' yazınız : ");
} while (Console.ReadLine().Trim().ToLower() == "evet");