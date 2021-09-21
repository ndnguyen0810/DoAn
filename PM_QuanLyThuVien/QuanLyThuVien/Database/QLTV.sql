/*==============================================================*/
/* DBMS name:      Sybase SQL Anywhere 12                       */
/* Created on:     21/09/2021 09:55:27                          */
/*==============================================================*/


--if exists(select 1 from sys.sysforeignkey where role='FK_CTPM_PHIEUMUON') then
--    alter table CTPM
--       delete foreign key FK_CTPM_PHIEUMUON
--end if;

--if exists(select 1 from sys.sysforeignkey where role='FK_CTPM_SACH') then
--    alter table CTPM
--       delete foreign key FK_CTPM_SACH
--end if;

--if exists(select 1 from sys.sysforeignkey where role='FK_PHAT_PHIEUMUON') then
--    alter table PHAT
--       delete foreign key FK_PHAT_PHIEUMUON
--end if;

--if exists(select 1 from sys.sysforeignkey where role='FK_PHIEUMUON_THUTHU') then
--    alter table PHIEUMUON
--       delete foreign key FK_PHIEUMUON_THUTHU
--end if;

--if exists(select 1 from sys.sysforeignkey where role='FK_PHIEUMUON_SINHVIEN') then
--    alter table PHIEUMUON
--       delete foreign key FK_PHIEUMUON_SINHVIEN
--end if;

--if exists(select 1 from sys.sysforeignkey where role='FK_SACH_LOAISACH') then
--    alter table SACH
--       delete foreign key FK_SACH_LOAISACH
--end if;

--if exists(select 1 from sys.sysforeignkey where role='FK_SACH_NXB') then
--    alter table SACH
--       delete foreign key FK_SACH_NXB
--end if;

--if exists(select 1 from sys.sysforeignkey where role='FK_TAIKHOAN_CHUCVU') then
--    alter table TAIKHOAN
--       delete foreign key FK_TAIKHOAN_CHUCVU
--end if;

--if exists(select 1 from sys.sysforeignkey where role='FK_TAIKHOAN_THUTHU') then
--    alter table TAIKHOAN
--       delete foreign key FK_TAIKHOAN_THUTHU
--end if;

--drop table if exists CHUCVU;

--drop table if exists CTPM;

--drop table if exists LOAISACH;

--drop table if exists NHANVIEN;

--drop table if exists NXB;

--drop table if exists PHAT;

--drop table if exists PHIEUMUON;

--drop table if exists SACH;

--drop table if exists SINHVIEN;

--drop table if exists TAIKHOAN;

/*==============================================================*/
/* Table: CHUCVU                                                */
/*==============================================================*/
create table CHUCVU 
(
   MACV                 varchar(6)                     not null,
   TENCV                varchar(50)                    null,
   constraint PK_CHUCVU primary key clustered (MACV)
);

/*==============================================================*/
/* Table: CTPM                                                  */
/*==============================================================*/
create table CTPM 
(
   MAPM                 varchar(6)                     not null,
   MASACH               varchar(6)                     not null,
   NGAYMUON             datetime                       null,
   HENTRA               datetime                       null,
   SOLUONG              int                        null,
   GHICHU               nvarchar(50)                    null,
   TRASACH              tinyint                        null,
   constraint PK_CTPM primary key clustered (MAPM, MASACH)
);

/*==============================================================*/
/* Table: LOAISACH                                              */
/*==============================================================*/
create table LOAISACH 
(
   MALOAI               varchar(6)                     not null,
   TENLOAI              nvarchar(50)                    null,
   constraint PK_LOAISACH primary key clustered (MALOAI)
);

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN 
(
   MANV                 varchar(6)                     not null,
   TENNV                nvarchar(50)                    null,
   NAMSINH              date                           null,
   DIACHI               nvarchar(50)                    null,
   SDT                  numeric(10)                    null,
   EMAIL                varchar(50)                    null,
   constraint PK_NHANVIEN primary key clustered (MANV)
);

/*==============================================================*/
/* Table: NXB                                                   */
/*==============================================================*/
create table NXB 
(
   MANXB                varchar(6)                     not null,
   TENNXB               nvarchar(50)                    null,
   constraint PK_NXB primary key clustered (MANXB)
);

/*==============================================================*/
/* Table: PHAT                                                  */
/*==============================================================*/
create table PHAT 
(
   ID_PHAT              int identity(1,1)               not null,
   LYDOPHAT             nvarchar(50)                    null,  
   HINHTHUCPHAT         varchar(50)                    null,
   TIEN                 money                          null,
   NGAYPHAT             datetime                       null,
   TRANGTHAIPHAT        tinyint                        null,
   MAPM                 varchar(6)                     null,
   MASACH               varchar(6)                     not null,
   constraint PK_PHAT primary key clustered (ID_PHAT)
);

/*==============================================================*/
/* Table: PHIEUMUON                                             */
/*==============================================================*/
create table PHIEUMUON 
(
   MAPM                 varchar(6)                     not null,
   MANV                 varchar(6)                     null,
   MSDG                 varchar(6)                     null,
   constraint PK_PHIEUMUON primary key clustered (MAPM)
);

/*==============================================================*/
/* Table: SACH                                                  */
/*==============================================================*/
create table SACH 
(
   MASACH               varchar(6)                     not null,
   TENSACH              nvarchar(50)                    null,
   TACGIA               nvarchar(50)                    null,
   NAMXB                numeric(4)                     null,
   MANXB                varchar(6)                     null,
   MALOAI               varchar(6)                     null,
   constraint PK_SACH primary key clustered (MASACH)
);

/*==============================================================*/
/* Table: SINHVIEN                                              */
/*==============================================================*/
create table DocGia 
(
   MSDG                 varchar(6)                     not null,
   HOTEN                nvarchar(50)                    null,
   NAMSINH              date                           null,
   DIACHI               varchar(100)                   null,
   SDT                  numeric(10)                    null,
   EMAIL                varchar(50)                    null,
   constraint PK_SINHVIEN primary key clustered (MSDG)
);

/*==============================================================*/
/* Table: TAIKHOAN                                              */
/*==============================================================*/
create table TAIKHOAN 
(
   IDTAIKHOAN           int         identity(1,1)                   not null,
   TENTK                varchar(20)                    null,
   MATKHAU              varchar(30)                    null,
   MANV                 varchar(6)                     not null,
   MACV                 varchar(6)                     not null,
   constraint PK_TAIKHOAN primary key clustered (IDTAIKHOAN, MANV, MACV)
);
go

alter table CTPM
   add constraint FK_CTPM_PHIEUMUON foreign key (MAPM)
      references PHIEUMUON (MAPM)
      on update cascade
      on delete cascade;
go

alter table CTPM
   add constraint FK_CTPM_SACH foreign key (MASACH)
      references SACH (MASACH)
      on update cascade
      on delete cascade;
go;

alter table PHAT
   add constraint FK_PHAT_PHIEUMUON foreign key (MAPM, MASACH)
      references CTPM (MAPM, MASACH)
      on update cascade
      on delete cascade;
go

alter table PHIEUMUON
   add constraint FK_PHIEUMUON_THUTHU foreign key (MANV)
      references NHANVIEN (MANV)
      on update cascade
      on delete cascade;
go

alter table PHIEUMUON
   add constraint FK_PHIEUMUON_DOCGIA foreign key (MSDG)
      references DOCGIA (MSDG)
      on update cascade
      on delete cascade;
go

alter table SACH
   add constraint FK_SACH_LOAISACH foreign key (MALOAI)
      references LOAISACH (MALOAI)
      on update cascade
      on delete cascade;

alter table SACH
   add constraint FK_SACH_NXB foreign key (MANXB)
      references NXB (MANXB)
      on update cascade
      on delete cascade;

alter table TAIKHOAN
   add constraint FK_TAIKHOAN_CHUCVU foreign key (MACV)
      references CHUCVU (MACV)
      on update cascade
      on delete cascade;

alter table TAIKHOAN
   add constraint FK_TAIKHOAN_THUTHU foreign key (MANV)
      references NHANVIEN (MANV)
      on update cascade
      on delete cascade;

