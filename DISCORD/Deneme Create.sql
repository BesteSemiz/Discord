Create Database Deneme

Create Table PorttanSil(
Id int Primary Key Identity(1,1) not null,
PortNo int
);

Create Table Yetki(
Id int Primary Key Identity(1,1) not null,
YetkiAd nvarchar(50),
Durum bit
);

Create Table Kullanici(
Id int Primary Key Identity(1,1) not null,
KullaniciAd nvarchar(100),
Sifre nvarchar(5),
IPAdres nvarchar(50),
PortNo nvarchar(50),
KullanciYetkiId int,
Durum bit
);

Create Table Arkadaslar(
Id int Primary Key Identity(1,1) not null,
KullaniciAd nvarchar(100),
ClientName nvarchar(100),
ClientIP nvarchar(50),
ClientPort nvarchar(50),
ArkIp nvarchar(50),
ArkPort nvarchar(50),
Durum bit
);

Create Table Mesajlar(
Id int primary key identity(1,1) not null,
KullaniciAd nvarchar(100),
Mesaj nvarchar(2000),
AliciAd nvarchar(100),
Durum bit
);

Create Table Oda(
Id int primary key identity(1,1) not null,
OdaAdi nvarchar(100),
OdaIp nvarchar(50),
OdaPort nvarchar(50),
KurucuAd nvarchar(100),
OdadakiKisiSayisi int,
Durum bit
);

Create Table OdaKisi(
Id int primary key identity(1,1) not null,
OdaAdi nvarchar(100),
KullaniciAdi nvarchar(100),
KullanciYetkiId int,
Durum bit
);

Create Proc YetkiEkle
@YetkiAd nvarchar(50),
@Durum bit
as
begin
insert into Yetki(YetkiAd,Durum)
values (@YetkiAd,@Durum)
end

exec YetkiEkle Uye,1
exec YetkiEkle Yonetici,1

Create Proc PorttanSilNo 
@PortNo int
as
begin
insert into PorttanSil(PortNo)
values (@PortNo)
end

exec PorttanSilNo 2030
exec PorttanSilNo 2031
exec PorttanSilNo 2082
exec PorttanSilNo 2083
exec PorttanSilNo 2086
exec PorttanSilNo 2087
exec PorttanSilNo 2095
exec PorttanSilNo 2096
exec PorttanSilNo 2181
exec PorttanSilNo 2222
exec PorttanSilNo 2447
exec PorttanSilNo 2710
exec PorttanSilNo 2809
exec PorttanSilNo 3050
exec PorttanSilNo 3074
exec PorttanSilNo 3128
exec PorttanSilNo 3306
exec PorttanSilNo 3389
exec PorttanSilNo 3396
exec PorttanSilNo 3689
exec PorttanSilNo 3690
exec PorttanSilNo 3724
exec PorttanSilNo 3784
exec PorttanSilNo 4662
exec PorttanSilNo 4894
exec PorttanSilNo 4899
exec PorttanSilNo 5000
exec PorttanSilNo 5003
exec PorttanSilNo 5121
exec PorttanSilNo 5190
exec PorttanSilNo 5222
exec PorttanSilNo 5223
exec PorttanSilNo 5269
exec PorttanSilNo 5432
exec PorttanSilNo 5517
exec PorttanSilNo 5800
exec PorttanSilNo 5900
exec PorttanSilNo 6000
exec PorttanSilNo 6346
exec PorttanSilNo 6600
exec PorttanSilNo 6667
exec PorttanSilNo 9009
exec PorttanSilNo 9715
exec PorttanSilNo 9714

Create Proc KullaniciEkle
@KullaniciAd nvarchar(100),
@Sifre nvarchar(5),
@IPAdres nvarchar(50),
@PortNo nvarchar (50),
@KullanciYetkiId int,
@Durum bit
as
begin
insert into Kullanici(KullaniciAd,Sifre,IPAdres,PortNo,KullanciYetkiId,Durum)
values (@KullaniciAd,@Sifre,@IPAdres,@PortNo,1,@Durum)
end

Create Proc MesajEkle
@KullaniciAd nvarchar(100),
@Mesaj nvarchar(2000),
@AliciAd nvarchar(100),
@Durum bit
as
begin
insert into Mesajlar(KullaniciAd,Mesaj,AliciAd,Durum)
values(@KullaniciAd,@Mesaj,@AliciAd,@Durum)
end

Create Proc ArkadasEkle
@KullaniciAd nvarchar(100),
@ClientName nvarchar(100),
@ClientIP nvarchar(50),
@ClientPort nvarchar(50),
@ArkIp nvarchar(50),
@ArkPort nvarchar(50),
@Durum bit
as
begin
insert into Arkadaslar(KullaniciAd,ClientName,ClientIP,ClientPort,ArkIp,ArkPort,Durum)
values(@KullaniciAd,@ClientName,@ClientIP,@ClientPort,@ArkIp,@ArkPort,@Durum)
end

Create Proc OdaEkle
@OdaAdi nvarchar(100),
@OdaIp nvarchar(50),
@OdaPort nvarchar(50),
@KurucuAd nvarchar(100),
@OdadakiKisiSayisi int,
@Durum bit
as
begin
insert into Oda(OdaAdi,OdaIp,OdaPort,KurucuAd,OdadakiKisiSayisi,Durum)
values(@OdaAdi,@OdaIp,@OdaPort,@KurucuAd,@OdadakiKisiSayisi,@Durum)
end

Create Proc OdayaKisiEkle
@OdaAdi nvarchar(100),
@KullaniciAdi nvarchar(100),
@Durum bit
as
begin
insert into OdaKisi(OdaAdi,KullaniciAdi,KullanciYetkiId,Durum)
values(@OdaAdi,@KullaniciAdi,1,@Durum)
end

Create Trigger OdaKisiEkle
on Oda
after insert
as
declare @OdaAdi nvarchar(100)
declare @KullaniciAdi nvarchar(100)
declare @KurucuAd nvarchar(100)
select @OdaAdi=OdaAdi from inserted
select KurucuAd from Oda where @OdaAdi=OdaAdi
select @KurucuAd=KurucuAd from inserted
insert into OdaKisi(OdaAdi,KullaniciAdi,KullanciYetkiId,Durum)
values(@OdaAdi,@KurucuAd,2,1)
update Oda set OdadakiKisiSayisi +=1 where @OdaAdi=OdaAdi

Create Trigger OdaSil
on Oda
after delete
as
declare @OdaAdi nvarchar(100)
begin
delete from OdaKisi where @OdaAdi=OdaAdi
delete from Mesajlar where @OdaAdi=AliciAd
end

Create Trigger OdaKisiCikar
on OdaKisi
after delete
as
declare @OdaAdi nvarchar(100)
begin
update Oda set OdadakiKisiSayisi -=1 where @OdaAdi=OdaAdi
end
