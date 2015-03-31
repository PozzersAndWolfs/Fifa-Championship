using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FifaChampionshipWP
{
    public class Transitions
    {

        /// <summary>
        /// Set the Turnstile transition for this UIElement
        /// </summary>
        /// <param name="element"></param>
        public static void UseTurnstileTransition(UIElement element)
        {
            TransitionService.SetNavigationInTransition(element,
                new NavigationInTransition()
                {
                    Backward = new TurnstileTransition()
                    {
                        Mode = TurnstileTransitionMode.BackwardIn
                    },
                    Forward = new TurnstileTransition()
                    {
                        Mode = TurnstileTransitionMode.ForwardIn
                    }
                }
            );

            TransitionService.SetNavigationOutTransition(element,
                new NavigationOutTransition()
                {
                    Backward = new TurnstileTransition()
                    {
                        Mode = TurnstileTransitionMode.BackwardOut
                    },
                    Forward = new TurnstileTransition()
                    {
                        Mode = TurnstileTransitionMode.ForwardOut
                    }
                }
            );
        }

        /// <summary>
        /// Set the slide transition for this UIElement
        /// </summary>
        /// <param name="element"></param>
        public static void UseSlideTransition(UIElement element, SlideTransitionMode inModeSlide, SlideTransitionMode outModeSlide)
        {
            TransitionService.SetNavigationInTransition(element,
                new NavigationInTransition()
                {
                    Backward = new SlideTransition()
                    {
                        Mode = inModeSlide
                    },
                    Forward = new SlideTransition()
                    {
                        Mode = inModeSlide
                    }
                }
            );

            TransitionService.SetNavigationOutTransition(element,
                new NavigationOutTransition()
                {
                    Backward = new SlideTransition()
                    {
                        Mode = outModeSlide
                    },
                    Forward = new SlideTransition()
                    {
                        Mode = outModeSlide
                    }
                }
            );
        }
    }
}
