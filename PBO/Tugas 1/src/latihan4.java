import java.util.Scanner;

/**
 * Created by WiwiJuwita on 22/02/2017.
 */
public class latihan4 {
    public static void main(String[] args)
    {
        Scanner in = new Scanner(System.in);

        System.out.print("Masukan Panjang Persegi : ");
        int p = in.nextInt();
        System.out.print("Masukan Lebar Persegi : ");
        int l = in.nextInt();

        double luas = (double) p*l;
        double keliling = (double) 2*(p*l);

        System.out.println("Panjang : "+p);
        System.out.println("Lebar   : "+l);
        System.out.println("Luas    : "+luas);
        System.out.println("Keliling: "+keliling);
    }
}
