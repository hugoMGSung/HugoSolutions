using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace Herp.Wpf.App
{
    /// <summary>
    /// UIElement 를 데코레이트하는 추상클래스를 상속받아 투명꾸미기 클래스 생성
    /// </summary>
    public class TransparentAdorner : Adorner
    {
        public TransparentAdorner(UIElement adornedElement) : base(adornedElement) { }

        protected override void OnRender(DrawingContext drawingContext)
        {
            var brush = new SolidColorBrush { Color = Colors.Transparent };

            drawingContext.DrawRectangle(brush, null, new Rect(new Point(0, 0), DesiredSize));
            base.OnRender(drawingContext);
        }
    }
}
