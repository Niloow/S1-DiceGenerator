
//stappenplan:
//interface maken
//button maakt de listbox leeg 
//button haalt text op uit box dobbelstenen, maalt dit keer het aantal ogen en geeft uitkomst weer in listbox. 
//button plaatst aantal dobbestenen onder elkaar toe
//textbox 'totaal aantal ogen' haalt items uit listbox op en geeft totaal weer.


namespace WinFormsApp1
{
    public partial class FDobbelstenengenerator : Form
    {
        
        public FDobbelstenengenerator()
        {
            InitializeComponent();
        }
               

        private void Bgooi_Click(object sender, EventArgs e)
        {
            //listbox leegmaken
            //int's aanmaken voor ingegeven waardes dobbelstenen en max aantal ogen
            LBresultaat.Items.Clear();
            int dobbelstenen = Convert.ToInt32(NUDdobbelstenen.Value);
            int ogen = Convert.ToInt32(NUDogen.Value);           
                   
                       
            // random getal tussen 1 en ingegeven ogen maal 1
            // Herhaal dit voor het aantal dobbelstenen ingegeven          
            for (int i = 0; i < dobbelstenen; i++)
            {
                Random rdn = new Random();
                int random;
                random = rdn.Next(1,ogen + 1);
                LBresultaat.Items.Add(random.ToString());
            }
            //aanroepen van de berekenmethode.
            BerekenAantelOgen();
        }


        // poging tot method
        private int BerekenAantelOgen()
        {
            int resultaat = 0;
            foreach (string item in LBresultaat.Items)
            {
                int i = Convert.ToInt32(item);
                resultaat = i + resultaat;
            }

            TBtotaalaantalogen.Text = resultaat.ToString();
            return resultaat;
        }

                
        private void TBtotaalaantalogen_TextChanged(object sender, EventArgs e)
        {
            
        }

        

    }
}