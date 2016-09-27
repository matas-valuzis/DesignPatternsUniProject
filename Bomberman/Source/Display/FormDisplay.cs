﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = Bomberman.Source.Display.Rectangle;

namespace Bomberman.Source.Display
{
    class FormDisplay : IDisplay
    {
        private readonly Form _form;

        private Bitmap _image;

        private Color _color = Color.White;

        private PictureBox canvas;

        public FormDisplay(Form form)
        {
            _form = form;
            _form.FormBorderStyle = FormBorderStyle.FixedSingle;
            _form.MaximizeBox = false;
            _form.MinimizeBox = false;
            var pb = new PictureBox
            {
                Dock = DockStyle.Fill
            };
            _form.Controls.Add(pb);
            canvas = pb;
            _image = new Bitmap(_form.Width, _form.Height);
            canvas.Image = _image;
        }


        public void Refresh()
        {
            canvas.Refresh();
        }

        public void SetDimentions(int width, int lenght)
        {
            _form.Size = new Size(width, lenght);
            
        }

        public void SetColor(string code)
        {
            _color = ColorTranslator.FromHtml(code);
        }

        public void DrawBackground()
        {
            canvas.BackColor = _color;
        }

        public void DrawRectangle(Rectangle destination)
        {
            throw new NotImplementedException();
        }

        public void DrawImage(string image, Rectangle source, Rectangle destination)
        {
            throw new NotImplementedException();
        }

        public void DrawText(string text, Rectangle rectangle)
        {
            using (var g = Graphics.FromImage(_image))
            {
                var font = new Font("Courier", rectangle.Width);
                var brush = new SolidBrush(_color);
                var drawFormat = new StringFormat();
                g.DrawString(text, font, brush, rectangle.X, rectangle.Y, drawFormat);
                canvas.Invalidate();

            }
        }

        public void Clear()
        {
            _image.Dispose();
            _image = new Bitmap(_form.Width, _form.Height);
            canvas.Image = _image;
        }
    }
}