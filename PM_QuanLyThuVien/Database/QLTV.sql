create database QLTV
go
use QLTV
go
/*==============================================================*/
/* Table: CHUCVU                                                */
/*==============================================================*/
create table CHUCVU 
(
   MACV                 varchar(6)                     not null,
   TENCV                nvarchar(50)                    null,
   constraint PK_CHUCVU primary key clustered (MACV)
);
go

/*==============================================================*/
/* Table: CTPM                                                  */
/*==============================================================*/
create table CTPM 
(
   MAPM                 varchar(6)                     not null,
   MASACH               varchar(5)                     not null,
   NGAYMUON             datetime                       null,
   NGAYTRA              datetime                       null,
   SOLUONG              integer                        null,
   GHICHU               varchar(50)                    null,
   TRASACH              tinyint                        null,
   constraint PK_CTPM primary key clustered (MAPM, MASACH)
);
go

/*==============================================================*/
/* Table: KHOA                                                  */
/*==============================================================*/
create table KHOA 
(
   MAKHOA               char(5)                        not null,
   TENKHOA              varchar(50)                    null,
   constraint PK_KHOA primary key clustered (MAKHOA)
);
go

/*==============================================================*/
/* Table: LOAISACH                                              */
/*==============================================================*/
create table LOAISACH 
(
   MALOAI               varchar(5)                     not null,
   TENLOAI              varchar(50)                    null,
   constraint PK_LOAISACH primary key clustered (MALOAI)
);
go

/*==============================================================*/
/* Table: LOP                                                   */
/*==============================================================*/
create table LOP 
(
   MALOP                char(9)                        not null,
   TENLOP               varchar(50)                    null,
   MAKHOA               char(5)                        null,
   constraint PK_LOP primary key clustered (MALOP)
);
go

/*==============================================================*/
/* Table: NXB                                                   */
/*==============================================================*/
create table NXB 
(
   MANXB                varchar(5)                     not null,
   TENNXB               varchar(50)                    null,
   constraint PK_NXB primary key clustered (MANXB)
);
go

/*==============================================================*/
/* Table: PHIEUMUON                                             */
/*==============================================================*/
create table PHIEUMUON 
(
   MAPM                 varchar(6)                     not null,
   MSSV                 numeric(6)                     null,
   NGAYMUON             timestamp                      null,
   constraint PK_PHIEUMUON primary key clustered (MAPM)
);
go

/*==============================================================*/
/* Table: SACH                                                  */
/*==============================================================*/
create table SACH 
(
   MASACH               varchar(5)                     not null,
   MALOAI               varchar(5)                     null,
   MANXB                varchar(5)                     null,
   TENSACH              varchar(50)                    null,
   NAMXB                numeric(4)                     null,
   constraint PK_SACH primary key clustered (MASACH)
);
go

/*==============================================================*/
/* Table: SINHVIEN                                              */
/*==============================================================*/
create table SINHVIEN 
(
   MSSV                 numeric(6)                     not null,
   MALOP                char(9)                        null,
   HOTEN                varchar(50)                    null,
   NAMSINH              date                           null,
   DIACHI               varchar(100)                   null,
   SDT                  numeric(10)                    null,
   EMAIL                varchar(50)                    null,
   constraint PK_SINHVIEN primary key clustered (MSSV)
);
go

/*==============================================================*/
/* Table: TAIKHOAN                                              */
/*==============================================================*/
create table TAIKHOAN 
(
   IDTAIKHOAN           int                            not null,
   MATT                 varchar(5)                     not null,
   MACV                 varchar(6)                     not null,
   TENTK                varchar(20)                    null,
   MATKHAU              varchar(30)                    null,
   constraint PK_TAIKHOAN primary key clustered (IDTAIKHOAN, MATT, MACV)
);
go

/*==============================================================*/
/* Table: THUTHU                                                */
/*==============================================================*/
create table THUTHU 
(
   MATT                 varchar(5)                     not null,
   MASACH               varchar(5)                     null,
   MAPM                 varchar(6)                     null,
   MACV                 varchar(6)                     null,
   TENTHUTHU            varchar(50)                    null,
   NAMSINH              date                           null,
   DIACHI               varchar(50)                    null,
   SDT                  numeric(10)                    null,
   EMAIL                varchar(50)                    null,
   constraint PK_THUTHU primary key clustered (MATT)
);
go

alter table CTPM
   add constraint FK_CTPM_SACH foreign key (MASACH)
      references SACH (MASACH)
      on update cascade
      on delete cascade;
go

alter table CTPM
   add constraint FK_CTPM_PHIEUMUON foreign key (MAPM)
      references PHIEUMUON (MAPM)
      on update cascade
      on delete cascade;
go
alter table LOP
   add constraint FK_LOP_KHOA foreign key (MAKHOA)
      references KHOA (MAKHOA)
      on update cascade
      on delete cascade;
go
alter table PHIEUMUON
   add constraint FK_PHIEUMUON_SINHVIEN foreign key (MSSV)
      references SINHVIEN (MSSV)
      on update cascade
      on delete cascade;
go

alter table SACH
   add constraint FK_SACH_NXB foreign key (MANXB)
      references NXB (MANXB)
      on update cascade
      on delete cascade;
go

alter table SACH
   add constraint FK_SACH_LOAISACH foreign key (MALOAI)
      references LOAISACH (MALOAI)
      on update cascade
      on delete cascade;
go

alter table SINHVIEN
   add constraint FK_SINHVIEN_LOP foreign key (MALOP)
      references LOP (MALOP)
      on update cascade
      on delete cascade;
go

alter table TAIKHOAN
   add constraint FK_TAIKHOAN_THUTHU foreign key (MATT)
      references THUTHU (MATT)
      on update cascade
      on delete cascade;
go

alter table TAIKHOAN
   add constraint FK_TAIKHOAN_CHUCVU foreign key (MACV)
      references CHUCVU (MACV)
      on update cascade
      on delete cascade;
go

alter table THUTHU
   add constraint FK_THUTHU_CHUCVU foreign key (MACV)
      references CHUCVU (MACV)
      on update cascade
      on delete cascade;
go

alter table THUTHU
   add constraint FK_THUTHU_SACH foreign key (MASACH)
      references SACH (MASACH)
      on update cascade
      on delete cascade;
go

alter table THUTHU
   add constraint FK_THUTHU_PHIEUMUON foreign key (MAPM)
      references PHIEUMUON (MAPM)
      on update cascade
      on delete cascade;

go
