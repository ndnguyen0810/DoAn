create database QLTV
go

/*==============================================================*/
/* Table: CHUCVU                                                */
/*==============================================================*/
create table CHUCVU 
(
   MACV                 varchar(10)                     not null,
   TENCV                nvarchar(50)                    null,
   constraint PK_CHUCVU primary key clustered (MACV)
);
go

/*==============================================================*/
/* Table: CTPM                                                  */
/*==============================================================*/
create table CTPM 
(
   MAPM                 varchar(10)                     not null,
   MASACH               varchar(10)                     not null,
   HENTRA               date                     null,
   SOLUONG              integer                        null,
   TRANGTHAI			INT NOT NULL
   constraint PK_CTPM primary key clustered (MAPM, MASACH)
);
go

/*==============================================================*/
/* Table: DOCGIA                                                */
/*==============================================================*/
create table DOCGIA 
(
   MADG                 varchar(10)                     not null,
   HOTEN                nvarchar(50)                    null,
   NAMSINH              date                           null,
   DIACHI               nvarchar(100)                   null,
   SDT                  numeric(10)                    null,
   EMAIL                varchar(50)                    null,
   constraint PK_DOCGIA primary key clustered (MADG)
);
go



/*==============================================================*/
/* Table: LOAISACH                                              */
/*==============================================================*/
create table LOAISACH 
(
   MALOAI               varchar(10)                     not null,
   TENLOAI              nvarchar(50)                    null,
   constraint PK_LOAISACH primary key clustered (MALOAI)
);
go

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN 
(
   MANV                 varchar(10)                     not null,
   TENNV                nvarchar(50)                    null,
   NAMSINH              datetime                           null,
   DIACHI               nvarchar(50)                    null,
   SDT                  varchar(10)                    null,
   EMAIL                varchar(50)                    null,
   NGAYVAOLAM DATE NOT NULL
   constraint PK_NHANVIEN primary key clustered (MANV)
);
go


/*==============================================================*/
/* Table: NXB                                                   */
/*==============================================================*/
create table NXB 
(
   MANXB                varchar(10)                     not null,
   TENNXB               nvarchar(50)                    null,
   DIACHI NVARCHAR(100) NOT NULL,
   SDT VARCHAR(10) NOT NULL,
   WEBSIZE VARCHAR(100) NOT NULL,
   EMAIL VARCHAR(100) NOT NULL,
   constraint PK_NXB primary key  (MANXB)
);
go

/*==============================================================*/
/* Table: PHAT                                                  */
/*==============================================================*/
create table PHAT 
(
   ID_PHAT              int identity(1,1)                        not null,
   LYDOPHAT             nvarchar(50)                    null,   
   HINHTHUCPHAT         nvarchar(50)                    null,
   GhiChu                 nvarchar(50)                          null,
   NGAYPHAT             datetime                       null,
   TRANGTHAIPHAT        bit                        null,
   MAPM                 varchar(10)                     null,
   MASACH               varchar(10)                     not null,
   constraint PK_PHAT primary key clustered (ID_PHAT)
);
go

/*==============================================================*/
/* Table: PHIEUMUON                                             */
/*==============================================================*/
create table PHIEUMUON 
(
   MAPM                 varchar(10)                     not null,
   MANV                 varchar(10)                     null,
   MADG                 varchar(10)                     null,
   NGAYMUON date not null,
   SOLUONG INT NULL,
   TRANGTHAI INT NULL
   constraint PK_PHIEUMUON primary key clustered (MAPM)
);
go

/*==============================================================*/
/* Table: SACH                                                  */
/*==============================================================*/
create table SACH 
(
   MASACH               varchar(10)                     not null,
   TENSACH              nvarchar(50)                    null,
   TACGIA               varchar(100)                    null,
   SOLUONG INT NOT NULL,
   NAMXB                numeric(4)                     null,
   MANXB                varchar(10)                   not  null,
   MAVT                 varchar(10)                     null,
   constraint PK_SACH primary key clustered (MASACH)
);
go


/*==============================================================*/
/* Table: TAIKHOAN                                              */
/*==============================================================*/

create table TAIKHOAN 
(
   MATK           VARCHAR(10)                            not null,
   TENTK                varchar(20)                    null,
   MATKHAU              varchar(30)                    null,
   MANV                 varchar(10)                     not null,
   MACV                 varchar(10)                     not null,
   constraint PK_TAIKHOAN primary key clustered (MATK, MANV, MACV)
);
go

/*==============================================================*/
/* Table: VITRI                                                 */
/*==============================================================*/
create table VITRI 
(
   MAVT                 varchar(10)                     not null,
   MALOAI               varchar(10)                     null,
   TENVITRI             nvarchar(50)                    null,
   constraint PK_VITRI primary key clustered (MAVT)
);
go

/*==============================================================*/
/* Constraint												   */
/*==============================================================*/

-- Chưa tạo ràng buộc ahihi
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
go
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
   add constraint FK_PHIEUMUON_SINHVIEN foreign key (MADG)
      references DOCGIA (MADG)
      on update cascade
      on delete cascade;
go
alter table SACH
   add constraint FK_SACH_VITRI foreign key (MAVT)
      references VITRI (MAVT)
      on update cascade
      on delete cascade;
go

alter table SACH
  add constraint FK_SACH_NXB foreign key (MANXB)
      references NXB (MANXB)
      on update cascade
      on delete cascade
go

alter table TAIKHOAN
   add constraint FK_TAIKHOAN_CHUCVU foreign key (MACV)
      references CHUCVU (MACV)
      on update cascade
      on delete cascade;
go
alter table TAIKHOAN
   add constraint FK_TAIKHOAN_THUTHU foreign key (MANV)
      references NHANVIEN (MANV)
      on update cascade
      on delete cascade;
go
alter table VITRI
   add constraint FK_VITR_LOAISACH foreign key (MALOAI)
      references LOAISACH (MALOAI)
      on update cascade
      on delete cascade;
go
