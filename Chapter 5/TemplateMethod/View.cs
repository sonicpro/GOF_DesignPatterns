using System;

namespace TemplateMethod
{
    // "AbstractClass" from template method pattern.
    public abstract class View
    {
        /// <summary>
        /// Template method - the only method available for the clients.
        /// <see cref="Program"/>
        /// </summary>
        public void Display()
        {
            SetFocus();
            DoDisplay();
            ResetFocus();
        }

        #region Primitive operations - not supposed to be called directly

        private void SetFocus()
        {
            Console.WriteLine("FocusIn...");
        }

        private void ResetFocus()
        {
            Console.WriteLine("FocusOut...");
        }

        #endregion

        // Abstract operation - not supposed to be called directly either, so protected.
        protected abstract void DoDisplay();
    }
}
