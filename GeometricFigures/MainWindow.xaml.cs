using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GeometricFigures
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        private Triangle currentTriangle;
        private Quadrilateral currentQuad;
        private Square currentSquare;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawLine(Point2D p1, Point2D p2, Brush color)
        {
            var line = new Line
            {
                X1 = p1.GetX(),
                Y1 = p1.GetY(),
                X2 = p2.GetX(),
                Y2 = p2.GetY(),
                Stroke = color,
                StrokeThickness = 2,
            };
            SceneCanvas.Children.Add(line);
        }

        private void ClearCanvas() => SceneCanvas.Children.Clear();

        private Point2D GenerateRandomPoint() =>
            new Point2D(random.Next(0, (int)SceneCanvas.ActualWidth),
                        random.Next(0, (int)SceneCanvas.ActualHeight));

        private void BtnDrawTriangle_Click(object sender, RoutedEventArgs e)
        {
            ClearCanvas();
            currentTriangle = new Triangle(
                GenerateRandomPoint(),
                GenerateRandomPoint(),
                GenerateRandomPoint()
            );
            DrawTriangle(currentTriangle, Brushes.Red);
        }

        private void DrawTriangle(Triangle triangle, Brush color)
        {
            var points = triangle.GetPoints().ToArray();
            DrawLine(points[0], points[1], color);
            DrawLine(points[1], points[2], color);
            DrawLine(points[2], points[0], color);
        }

        private void BtnDrawQuad_Click(object sender, RoutedEventArgs e)
        {
            ClearCanvas();
            currentQuad = new Quadrilateral(
                GenerateRandomPoint(),
                random.Next(50, 200),
                random.Next(50, 200)
            );
            DrawQuadrilateral(currentQuad, Brushes.Blue);
        }

        private void DrawQuadrilateral(Quadrilateral quad, Brush color)
        {
            var points = quad.GetPoints();
            for (int i = 0; i < points.Length; i++)
            {
                DrawLine(points[i], points[(i + 1) % points.Length], color);
            }
        }

        private void BtnDrawSquare_Click(object sender, RoutedEventArgs e)
        {
            ClearCanvas();
            currentSquare = new Square(
                GenerateRandomPoint(),
                random.Next(50, 200)
            );
            DrawQuadrilateral(currentSquare, Brushes.Green);
        }

        private void BtnMove_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(TxtShiftX.Text, out double dx) ||
                !double.TryParse(TxtShiftY.Text, out double dy)) return;

            ClearCanvas();

            if (currentTriangle != null)
            {
                currentTriangle.Move(dx, dy);
                DrawTriangle(currentTriangle, Brushes.Red);
            }
            else if (currentQuad != null)
            {
                currentQuad.Move(dx, dy);
                DrawQuadrilateral(currentQuad, Brushes.Blue);
            }
            else if (currentSquare != null)
            {
                currentSquare.Move(dx, dy);
                DrawQuadrilateral(currentSquare, Brushes.Green);
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e) => ClearCanvas();
    }
}