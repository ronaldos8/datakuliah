import javax.security.sasl.SaslServer;

/**
 * Created by RonaldoSimanjuntak on 22/02/2017.
 */
public class latihan2 {
    public static void main(String[] args)
    {
        int kode;
        int umur = 25; //variabel yang dapat langsung diinisiasi
        boolean isDibawahUmur; //perhatikan penulisan nama variabel

        kode = 1234;
        double gaji;

        gaji = 5500000.23;
        isDibawahUmur = true;
        System.out.println("Umur : "+umur);
        System.out.println("Gaji : "+gaji);

        System.out.println();
        int a = 10;
        int b = 3;
        double c = (double) a/b;
        System.out.println("Nilai : "+c);

        // ketika diganti menjadi double c = (double) (a/b) angka yang dijadikan double adalah hasil a/b yang sudah
        // berbentuk integer
    }

}
