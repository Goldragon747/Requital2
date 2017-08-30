using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Requital
{
    public class Movement
    {
        public int direction = 1; // NORTH = 1 EAST = 2 SOUTH = 3 WEST = 4
        public System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        public System.Windows.Threading.DispatcherTimer movementTimer = new System.Windows.Threading.DispatcherTimer();
        public int tick = 0;
        public bool disable = false;
        public bool isMoving = false;

        MainWindow mainWindow;

        private double x = 0;
        private double y = 0;

        private int speed = 6;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Movement(MainWindow window,int xPos, int yPos)
        {
            mainWindow = window;
            SetTimer();
            x = xPos;
            y = yPos;
        }

        private void SetTimer()
        {
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(400000); //500000
            movementTimer.Tick += movement;
            movementTimer.Interval = new TimeSpan(300000); //500000
        }
        private void movement(object sender, EventArgs e)
        {
            if (isMoving)
            {
                if (mainWindow.Cave.IsVisible)
                {
                    if (direction == 1)
                    {
                        switch (tick)
                        {
                            case 0:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_up_1;
                                break;
                            case 1:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_up_2;
                                break;
                            case 2:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_up_3;
                                break;
                            case 3:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_up_4;
                                break;
                            case 4:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_up_5;
                                break;
                            case 5:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_up_6;
                                break;
                            case 6:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_up_7;
                                break;
                            case 7:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_up_8;
                                break;
                        }
                    }
                    else if (direction == 2)
                    {
                        switch (tick)
                        {
                            case 0:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_right_1;
                                break;
                            case 1:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_right_2;
                                break;
                            case 2:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_right_3;
                                break;
                            case 3:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_right_4;
                                break;
                            case 4:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_right_5;
                                break;
                            case 5:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_right_6;
                                break;
                            case 6:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_right_7;
                                break;
                            case 7:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_right_8;
                                break;
                        }
                    }
                    else if (direction == 3)
                    {
                        switch (tick)
                        {
                            case 0:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_down_1;
                                break;
                            case 1:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_down_2;
                                break;
                            case 2:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_down_3;
                                break;
                            case 3:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_down_4;
                                break;
                            case 4:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_down_5;
                                break;
                            case 5:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_down_6;
                                break;
                            case 6:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_down_7;
                                break;
                            case 7:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_down_8;
                                break;
                        }
                    }
                    else if (direction == 4)
                    {
                        switch (tick)
                        {
                            case 0:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_left_1;
                                break;
                            case 1:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_left_2;
                                break;
                            case 2:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_left_3;
                                break;
                            case 3:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_left_4;
                                break;
                            case 4:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_left_5;
                                break;
                            case 5:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_left_6;
                                break;
                            case 6:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_left_7;
                                break;
                            case 7:
                                mainWindow.Cave.Sprite = mainWindow.assets.rouge_left_8;
                                break;
                        }
                    }
                } else if (mainWindow.Desert.IsVisible)
                {
                    if (direction == 1)
                    {
                        switch (tick)
                        {
                            case 0:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_up_1;
                                break;
                            case 1:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_up_2;
                                break;
                            case 2:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_up_3;
                                break;
                            case 3:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_up_4;
                                break;
                            case 4:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_up_5;
                                break;
                            case 5:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_up_6;
                                break;
                            case 6:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_up_7;
                                break;
                            case 7:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_up_8;
                                break;
                        }
                    }
                    else if (direction == 2)
                    {
                        switch (tick)
                        {
                            case 0:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_right_1;
                                break;
                            case 1:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_right_2;
                                break;
                            case 2:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_right_3;
                                break;
                            case 3:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_right_4;
                                break;
                            case 4:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_right_5;
                                break;
                            case 5:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_right_6;
                                break;
                            case 6:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_right_7;
                                break;
                            case 7:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_right_8;
                                break;
                        }
                    }
                    else if (direction == 3)
                    {
                        switch (tick)
                        {
                            case 0:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_down_1;
                                break;
                            case 1:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_down_2;
                                break;
                            case 2:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_down_3;
                                break;
                            case 3:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_down_4;
                                break;
                            case 4:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_down_5;
                                break;
                            case 5:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_down_6;
                                break;
                            case 6:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_down_7;
                                break;
                            case 7:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_down_8;
                                break;
                        }
                    }
                    else if (direction == 4)
                    {
                        switch (tick)
                        {
                            case 0:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_left_1;
                                break;
                            case 1:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_left_2;
                                break;
                            case 2:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_left_3;
                                break;
                            case 3:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_left_4;
                                break;
                            case 4:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_left_5;
                                break;
                            case 5:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_left_6;
                                break;
                            case 6:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_left_7;
                                break;
                            case 7:
                                mainWindow.Desert.Sprite = mainWindow.assets.rouge_left_8;
                                break;
                        }
                    }
                }
            }

            tick += (tick == 7) ? -7 : 1;
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (isMoving)
            {
                if (direction == 1) //30
                {
                    for (int i = 0; i < 16; i++)
                    {
                        Y += speed;
                        mainWindow.MoveCanvasTop(Y);
                        mainWindow.Triggered = mainWindow.HitDetection();
                        if (mainWindow.Triggered)
                        {
                            Y -= 3;
                            mainWindow.MoveCanvasTop(Y);
                        } 
                        
                    }
                }
                else if (direction == 3)
                {
                    for (int i = 0; i < 16; i++)
                    {
                        Y -= speed;
                        mainWindow.MoveCanvasTop(Y);
                        mainWindow.Triggered = mainWindow.HitDetection();
                        if (mainWindow.Triggered)
                        {
                            Y += 3;
                            mainWindow.MoveCanvasTop(Y);
                        } 
                    }
                }
                else if (direction == 4)
                {
                    for (int i = 0; i < 19; i++)
                    {
                        X += speed;
                        mainWindow.MoveCanvasLeft(X);
                        mainWindow.Triggered = mainWindow.HitDetection();
                        if (mainWindow.Triggered)
                        {
                            X -= 3;
                            mainWindow.MoveCanvasLeft(X);
                        } 
                    }
                }
                else if (direction == 2)
                {
                    for (int i = 0; i < 19; i++)
                    {
                        X -= speed;
                        mainWindow.MoveCanvasLeft(X);
                        mainWindow.Triggered = mainWindow.HitDetection();
                        if (mainWindow.Triggered)
                        {
                            X += 3;
                            mainWindow.MoveCanvasLeft(X);
                        } 
                    }
                }
                mainWindow.TryTriggerCombat();
            }
        }
        public void OnButtonKeyDown(object sender, KeyEventArgs e)
        {
            if (!disable)
            {
                if (e.Key.ToString() == "W")
                {
                    isMoving = true;
                    direction = 1;
                }
                else if (e.Key.ToString() == "S")
                {
                    isMoving = true;
                    direction = 3;
                }
                else if (e.Key.ToString() == "A")
                {
                    isMoving = true;
                    direction = 4;
                }
                else if (e.Key.ToString() == "D")
                {
                    isMoving = true;
                    direction = 2;
                }
                if (isMoving)
                {
                    movementTimer.Start();
                    dispatcherTimer.Start();
                }
            }
        }
        public void OnButtonKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "W")
            {
                isMoving = false;
            }
            else if (e.Key.ToString() == "S")
            {
                isMoving = false;
            }
            else if (e.Key.ToString() == "A")
            {
                isMoving = false;
            }
            else if (e.Key.ToString() == "D")
            {
                isMoving = false;
            }
            if (!isMoving)
            {
                movementTimer.Stop();
                dispatcherTimer.Stop();
                if (mainWindow.Cave.IsVisible)
                {
                    switch (direction)
                    {
                        case 1:
                            mainWindow.Cave.Sprite = mainWindow.assets.rouge_up_1;
                            break;
                        case 2:
                            mainWindow.Cave.Sprite = mainWindow.assets.rouge_right_1;
                            break;
                        case 3:
                            mainWindow.Cave.Sprite = mainWindow.assets.rouge_down_1;
                            break;
                        case 4:
                            mainWindow.Cave.Sprite = mainWindow.assets.rouge_left_1;
                            break;
                    }
                } else if (mainWindow.Desert.IsVisible)
                {
                    switch (direction)
                    {
                        case 1:
                            mainWindow.Desert.Sprite = mainWindow.assets.rouge_up_1;
                            break;
                        case 2:
                            mainWindow.Desert.Sprite = mainWindow.assets.rouge_right_1;
                            break;
                        case 3:
                            mainWindow.Desert.Sprite = mainWindow.assets.rouge_down_1;
                            break;
                        case 4:
                            mainWindow.Desert.Sprite = mainWindow.assets.rouge_left_1;
                            break;
                    }
                }
                
            }
        }
    }
}
