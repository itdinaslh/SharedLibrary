﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SharedLibrary.Entities.Common;

namespace SharedLibrary.Entities.Address;

[Table("Kelurahan")]
public class Kelurahan
{
#nullable disable
    [MaxLength(15, ErrorMessage = "Maksimal 15 Karakter")]
    [Required(ErrorMessage = "Kode Kelurahan/Desa Wajib Diisi")]
    public string KelurahanID { get; set; }

    [Required(ErrorMessage = "Nama Kelurahan/Desa Wajib Diisi")]
    [MaxLength(150, ErrorMessage = "Maksimal 150 Karakter")]
    public string NamaKelurahan { get; set; }

#nullable enable
    [MaxLength(30, ErrorMessage = "Maksimal 30 Karakter")]
    public string? Latitude { get; set; }

    [MaxLength(30, ErrorMessage = "Maksimal 30 Karakter")]
    public string? Longitude { get; set; }

#nullable disable
    [MaxLength(10)]
    public string KecamatanID { get; set; }

    public Kecamatan Kecamatan { get; set; }

    public List<ClientPkm> ClientPkms { get; set; }

    //public List<LokasiAngkut> LokasiAngkuts { get; set; }
}