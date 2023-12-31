using Microsoft.EntityFrameworkCore;
using UMS.Profile.Domain.Entities;

namespace Infrastructure.Seeders.UMS.Profile;

public class CountrySeeder : BaseSeeder
{
    public readonly List<Country> Countries = new()
    {
        CreateCountry("AD", "Andorra"),
        CreateCountry("AE", "UnitedArabEmirates"),
        CreateCountry("AF", "Afghanistan"),
        CreateCountry("AG", "Antigua&Barbuda"),
        CreateCountry("AI", "Anguilla"),
        CreateCountry("AL", "Albania"),
        CreateCountry("AM", "Armenia"),
        CreateCountry("AO", "Angola"),
        CreateCountry("AQ", "Antarctica"),
        CreateCountry("AR", "Argentina"),
        CreateCountry("AS", "AmericanSamoa"),
        CreateCountry("AT", "Austria"),
        CreateCountry("AU", "Australia"),
        CreateCountry("AW", "Aruba"),
        CreateCountry("AX", "ÅlandIslands"),
        CreateCountry("AZ", "Azerbaijan"),
        CreateCountry("BA", "Bosnia&Herzegovina"),
        CreateCountry("BB", "Barbados"),
        CreateCountry("BD", "Bangladesh"),
        CreateCountry("BE", "Belgium"),
        CreateCountry("BF", "BurkinaFaso"),
        CreateCountry("BG", "Bulgaria"),
        CreateCountry("BH", "Bahrain"),
        CreateCountry("BI", "Burundi"),
        CreateCountry("BJ", "Benin"),
        CreateCountry("BL", "St.Barthélemy"),
        CreateCountry("BM", "Bermuda"),
        CreateCountry("BN", "Brunei"),
        CreateCountry("BO", "Bolivia"),
        CreateCountry("BQ", "CaribbeanNetherlands"),
        CreateCountry("BR", "Brazil"),
        CreateCountry("BS", "Bahamas"),
        CreateCountry("BT", "Bhutan"),
        CreateCountry("BV", "BouvetIsland"),
        CreateCountry("BW", "Botswana"),
        CreateCountry("BY", "Belarus"),
        CreateCountry("BZ", "Belize"),
        CreateCountry("CA", "Canada"),
        CreateCountry("CC", "Cocos (Keeling) Islands"),
        CreateCountry("CD", "Congo-Kinshasa"),
        CreateCountry("CF", "CentralAfricanRepublic"),
        CreateCountry("CG", "Congo-Brazzaville"),
        CreateCountry("CH", "Switzerland"),
        CreateCountry("CI", "Côted’Ivoire"),
        CreateCountry("CK", "CookIslands"),
        CreateCountry("CL", "Chile"),
        CreateCountry("CM", "Cameroon"),
        CreateCountry("CN", "China"),
        CreateCountry("CO", "Colombia"),
        CreateCountry("CR", "CostaRica"),
        CreateCountry("CU", "Cuba"),
        CreateCountry("CV", "CapeVerde"),
        CreateCountry("CW", "Curaçao"),
        CreateCountry("CX", "ChristmasIsland"),
        CreateCountry("CY", "Cyprus"),
        CreateCountry("CZ", "Czechia"),
        CreateCountry("DE", "Germany"),
        CreateCountry("DJ", "Djibouti"),
        CreateCountry("DK", "Denmark"),
        CreateCountry("DM", "Dominica"),
        CreateCountry("DO", "DominicanRepublic"),
        CreateCountry("DZ", "Algeria"),
        CreateCountry("EC", "Ecuador"),
        CreateCountry("EE", "Estonia"),
        CreateCountry("EG", "Egypt"),
        CreateCountry("EH", "WesternSahara"),
        CreateCountry("ER", "Eritrea"),
        CreateCountry("ES", "Spain"),
        CreateCountry("ET", "Ethiopia"),
        CreateCountry("FI", "Finland"),
        CreateCountry("FJ", "Fiji"),
        CreateCountry("FK", "FalklandIslands"),
        CreateCountry("FM", "Micronesia"),
        CreateCountry("FO", "FaroeIslands"),
        CreateCountry("FR", "France"),
        CreateCountry("GA", "Gabon"),
        CreateCountry("GB", "UnitedKingdom"),
        CreateCountry("GD", "Grenada"),
        CreateCountry("GE", "Georgia"),
        CreateCountry("GF", "FrenchGuiana"),
        CreateCountry("GG", "Guernsey"),
        CreateCountry("GH", "Ghana"),
        CreateCountry("GI", "Gibraltar"),
        CreateCountry("GL", "Greenland"),
        CreateCountry("GM", "Gambia"),
        CreateCountry("GN", "Guinea"),
        CreateCountry("GP", "Guadeloupe"),
        CreateCountry("GQ", "EquatorialGuinea"),
        CreateCountry("GR", "Greece"),
        CreateCountry("GS", "SouthGeorgia&SouthSandwichIslands"),
        CreateCountry("GT", "Guatemala"),
        CreateCountry("GU", "Guam"),
        CreateCountry("GW", "Guinea-Bissau"),
        CreateCountry("GY", "Guyana"),
        CreateCountry("HK", "HongKongSARChina"),
        CreateCountry("HM", "Heard&McDonaldIslands"),
        CreateCountry("HN", "Honduras"),
        CreateCountry("HR", "Croatia"),
        CreateCountry("HT", "Haiti"),
        CreateCountry("HU", "Hungary"),
        CreateCountry("ID", "Indonesia"),
        CreateCountry("IE", "Ireland"),
        CreateCountry("IL", "Israel"),
        CreateCountry("IM", "IsleofMan"),
        CreateCountry("IN", "India"),
        CreateCountry("IO", "BritishIndianOceanTerritory"),
        CreateCountry("IQ", "Iraq"),
        CreateCountry("IR", "Iran"),
        CreateCountry("IS", "Iceland"),
        CreateCountry("IT", "Italy"),
        CreateCountry("JE", "Jersey"),
        CreateCountry("JM", "Jamaica"),
        CreateCountry("JO", "Jordan"),
        CreateCountry("JP", "Japan"),
        CreateCountry("KE", "Kenya"),
        CreateCountry("KG", "Kyrgyzstan"),
        CreateCountry("KH", "Cambodia"),
        CreateCountry("KI", "Kiribati"),
        CreateCountry("KM", "Comoros"),
        CreateCountry("KN", "St.Kitts&Nevis"),
        CreateCountry("KP", "NorthKorea"),
        CreateCountry("KR", "SouthKorea"),
        CreateCountry("KW", "Kuwait"),
        CreateCountry("KY", "CaymanIslands"),
        CreateCountry("KZ", "Kazakhstan"),
        CreateCountry("LA", "Laos"),
        CreateCountry("LB", "Lebanon"),
        CreateCountry("LC", "St.Lucia"),
        CreateCountry("LI", "Liechtenstein"),
        CreateCountry("LK", "SriLanka"),
        CreateCountry("LR", "Liberia"),
        CreateCountry("LS", "Lesotho"),
        CreateCountry("LT", "Lithuania"),
        CreateCountry("LU", "Luxembourg"),
        CreateCountry("LV", "Latvia"),
        CreateCountry("LY", "Libya"),
        CreateCountry("MA", "Morocco"),
        CreateCountry("MC", "Monaco"),
        CreateCountry("MD", "Moldova"),
        CreateCountry("ME", "Montenegro"),
        CreateCountry("MF", "St.Martin"),
        CreateCountry("MG", "Madagascar"),
        CreateCountry("MH", "MarshallIslands"),
        CreateCountry("MK", "NorthMacedonia"),
        CreateCountry("ML", "Mali"),
        CreateCountry("MM", "Myanmar (Burma)"),
        CreateCountry("MN", "Mongolia"),
        CreateCountry("MO", "MacaoSARChina"),
        CreateCountry("MP", "NorthernMarianaIslands"),
        CreateCountry("MQ", "Martinique"),
        CreateCountry("MR", "Mauritania"),
        CreateCountry("MS", "Montserrat"),
        CreateCountry("MT", "Malta"),
        CreateCountry("MU", "Mauritius"),
        CreateCountry("MV", "Maldives"),
        CreateCountry("MW", "Malawi"),
        CreateCountry("MX", "Mexico"),
        CreateCountry("MY", "Malaysia"),
        CreateCountry("MZ", "Mozambique"),
        CreateCountry("NA", "Namibia"),
        CreateCountry("NC", "NewCaledonia"),
        CreateCountry("NE", "Niger"),
        CreateCountry("NF", "NorfolkIsland"),
        CreateCountry("NG", "Nigeria"),
        CreateCountry("NI", "Nicaragua"),
        CreateCountry("NL", "Netherlands"),
        CreateCountry("NO", "Norway"),
        CreateCountry("NP", "Nepal"),
        CreateCountry("NR", "Nauru"),
        CreateCountry("NU", "Niue"),
        CreateCountry("NZ", "NewZealand"),
        CreateCountry("OM", "Oman"),
        CreateCountry("PA", "Panama"),
        CreateCountry("PE", "Peru"),
        CreateCountry("PF", "FrenchPolynesia"),
        CreateCountry("PG", "PapuaNewGuinea"),
        CreateCountry("PH", "Philippines"),
        CreateCountry("PK", "Pakistan"),
        CreateCountry("PL", "Poland"),
        CreateCountry("PM", "St.Pierre&Miquelon"),
        CreateCountry("PN", "PitcairnIslands"),
        CreateCountry("PR", "PuertoRico"),
        CreateCountry("PS", "PalestinianTerritories"),
        CreateCountry("PT", "Portugal"),
        CreateCountry("PW", "Palau"),
        CreateCountry("PY", "Paraguay"),
        CreateCountry("QA", "Qatar"),
        CreateCountry("RE", "Réunion"),
        CreateCountry("RO", "Romania"),
        CreateCountry("RS", "Serbia"),
        CreateCountry("RU", "Russia"),
        CreateCountry("RW", "Rwanda"),
        CreateCountry("SA", "SaudiArabia"),
        CreateCountry("SB", "SolomonIslands"),
        CreateCountry("SC", "Seychelles"),
        CreateCountry("SD", "Sudan"),
        CreateCountry("SE", "Sweden"),
        CreateCountry("SG", "Singapore"),
        CreateCountry("SH", "St.Helena"),
        CreateCountry("SI", "Slovenia"),
        CreateCountry("SJ", "Svalbard&JanMayen"),
        CreateCountry("SK", "Slovakia"),
        CreateCountry("SL", "SierraLeone"),
        CreateCountry("SM", "SanMarino"),
        CreateCountry("SN", "Senegal"),
        CreateCountry("SO", "Somalia"),
        CreateCountry("SR", "Suriname"),
        CreateCountry("SS", "SouthSudan"),
        CreateCountry("ST", "SãoTomé&Príncipe"),
        CreateCountry("SV", "ElSalvador"),
        CreateCountry("SX", "SintMaarten"),
        CreateCountry("SY", "Syria"),
        CreateCountry("SZ", "Eswatini"),
        CreateCountry("TC", "Turks&CaicosIslands"),
        CreateCountry("TD", "Chad"),
        CreateCountry("TF", "FrenchSouthernTerritories"),
        CreateCountry("TG", "Togo"),
        CreateCountry("TH", "Thailand"),
        CreateCountry("TJ", "Tajikistan"),
        CreateCountry("TK", "Tokelau"),
        CreateCountry("TL", "Timor-Leste"),
        CreateCountry("TM", "Turkmenistan"),
        CreateCountry("TN", "Tunisia"),
        CreateCountry("TO", "Tonga"),
        CreateCountry("TR", "Turkey"),
        CreateCountry("TT", "Trinidad&Tobago"),
        CreateCountry("TV", "Tuvalu"),
        CreateCountry("TW", "Taiwan"),
        CreateCountry("TZ", "Tanzania"),
        CreateCountry("UA", "Ukraine"),
        CreateCountry("UG", "Uganda"),
        CreateCountry("UM", "U.S.OutlyingIslands"),
        CreateCountry("US", "UnitedStates"),
        CreateCountry("UY", "Uruguay"),
        CreateCountry("UZ", "Uzbekistan"),
        CreateCountry("VA", "VaticanCity"),
        CreateCountry("VC", "St.Vincent&Grenadines"),
        CreateCountry("VE", "Venezuela"),
        CreateCountry("VG", "BritishVirginIslands"),
        CreateCountry("VI", "U.S.VirginIslands"),
        CreateCountry("VN", "Vietnam"),
        CreateCountry("VU", "Vanuatu"),
        CreateCountry("WF", "Wallis&Futuna"),
        CreateCountry("WS", "Samoa"),
        CreateCountry("YE", "Yemen"),
        CreateCountry("YT", "Mayotte"),
        CreateCountry("ZA", "SouthAfrica"),
        CreateCountry("ZM", "Zambia"),
        CreateCountry("ZW", "Zimbabwe")
    };

    public CountrySeeder(ModelBuilder modelBuilder, int count = 1) : base(modelBuilder, count)
    {
    }

    public override void Seed()
    {
        ModelBuilder.Entity<Country>().HasData(Countries);
    }

    private static Country CreateCountry(string key, string name)
    {
        return new Country
        {
            Id = Guid.NewGuid(),
            Key = key,
            Name = name,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };
    }
}