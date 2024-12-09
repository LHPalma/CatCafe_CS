using System.Windows.Forms;

namespace CatCafe.Classes
{
    public static class Alertas
    {
        public static void PreenchaTodosOsCampos()
        {
            MessageBox.Show(text: "Preencha todos os campos!",
                            caption: "ATENÇÃO",
                            buttons: MessageBoxButtons.OK);
            return;
        }
    }
}
