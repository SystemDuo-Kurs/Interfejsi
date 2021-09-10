using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace jhh
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		

		public MainWindow()
		{
			InitializeComponent();

			Binding b = new();

			Asd a = new Asd{ Nesto = "asd", Bla = 50 };

			b.Source = a;
			b.Path = new PropertyPath("Nesto");

			txt.SetBinding(TextBox.TextProperty, b);

			Binding b2 = new();
			b2.Source = a;
			b2.Path = new PropertyPath("Bla");
			txt.SetBinding(TextBox.WidthProperty, b2);

			Binding b3 = new();
			b3.Source = a;
			b3.Path = new PropertyPath("Bla");
			b3.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
			txt2.SetBinding(TextBox.TextProperty, b3);

			Grupa a1 = new A();
			Grupa b1 = new B();
		}

		
	}

	public abstract class Grupa
	{
		public abstract void ZajednickaStvar();

		public void Zklj() { }
	}

	public class A : Grupa, INekiInterfejs
	{
		public int brojLol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public void BlaBla(int x)
		{
			throw new NotImplementedException();
		}

		public void Nesto()
		{
			throw new NotImplementedException();
		}
	}

	public class B : Grupa
	{
		public override void ZajednickaStvar()
		{
			throw new NotImplementedException();
		}
	}

	public interface INekiInterfejs
	{
		public int brojLol { get; set; }

		public void Nesto();
		public void BlaBla(int x);
	}

	public class Asd
	{
		public string Nesto { get; set; }
		public int Bla { get; set; }
	}
}
