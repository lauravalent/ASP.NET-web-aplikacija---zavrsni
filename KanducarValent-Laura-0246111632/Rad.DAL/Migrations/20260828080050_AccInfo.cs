using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rad.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AccInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Kuća Draga datira još iz 1929. godine kada je bila kućica u koju su njezini vlasnici dolazili kada su radili u vingoradima. Draga još uvijek ima vinograd odmah pored, no sada u nju dolaze gosti koji žele odmoriti dušu. Osim vinograda, Draga nudi i obilazak podrumom koji se nalazi odmah ispod jedne od soba. Draga ima dvije sobe tako da je pogodna za petero ljudi.", "/images/kuca_draga.jpeg" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Kuća Braco je najmanja kuća na našoj Farmici, no to ne umanjuje njenu vrijednost. Kuća Braco je odlična za mladi bračni par jer je i najbliža bazenu. Odamh pored nalazi se smokva koja je rodna cijelo ljeto. Pošto je najbliža životinjama, dok se odsjeda u Braci, one se najviše čuju tako da će Vas probuditi pijev pijetlova.", "/images/braco.jpg" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "ID",
                keyValue: 4,
                column: "Description",
                value: "Kuća Laura ima veliki vinograd koji pruža prekrasan pogled i mogućnost uživanja u svježem grožđu tijekom sezone.Ima dvije sobe te veliku kupaonu. Kuća Laura je naša prva Kuća kojoj smo dali novi izgled te ju uredili kako bi ugostila svoje goste.");

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Kuća Janko ima veliku terasu na kojoj gosti mogu uživati u jutarnjoj kavi ili večernjem opuštanju. Unutrašnjost kuće je prostrana i udobna, s modernim namještajem i svim potrebnim sadržajima za ugodan boravak.Prostrana kuhinja omogućava lagano pripremanje obroka, a tijekom jela se može uživati u pogledu na vinograd i šumu.", "/images/marijan.jpeg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Apartman Sofija je moderan i udoban apartman smješten u srcu grada. Sadrži sve potrebne sadržaje za ugodan boravak, uključujući potpuno opremljenu kuhinju, prostranu dnevnu sobu i udobnu spavaću sobu. Idealno za parove ili male obitelji.", "/images/Janko.jpg" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Apartman Sofija je moderan i udoban apartman smješten u srcu grada. Sadrži sve potrebne sadržaje za ugodan boravak, uključujući potpuno opremljenu kuhinju, prostranu dnevnu sobu i udobnu spavaću sobu. Idealno za parove ili male obitelji.", "/images/braco1.jpg" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "ID",
                keyValue: 4,
                column: "Description",
                value: "Apartman Sofija je moderan i udoban apartman smješten u srcu grada. Sadrži sve potrebne sadržaje za ugodan boravak, uključujući potpuno opremljenu kuhinju, prostranu dnevnu sobu i udobnu spavaću sobu. Idealno za parove ili male obitelji.");

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Apartman Sofija je moderan i udoban apartman smješten u srcu grada. Sadrži sve potrebne sadržaje za ugodan boravak, uključujući potpuno opremljenu kuhinju, prostranu dnevnu sobu i udobnu spavaću sobu. Idealno za parove ili male obitelji.", "/images/more.jpeg" });
        }
    }
}
