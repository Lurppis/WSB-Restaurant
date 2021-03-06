# WSB Restaurant

## AGENDA
## Table of Contents
- [Introduction](#introduction)
- [Code samples](#code-samples)
- [Instalation](#installation)
- [Testing](#testing)


## Introduction

> Hello, this is my school project, Mc Donald order clone. Restaurant has their own priority, car client should be placed at the top of stack, rest of clients to the end of queue. Application should use .Net, threading, random function and simple I/O.


> Client app window has no access to minimize or exit app.

![zrzut ekranu 2017-12-21 o 12 05 59](https://user-images.githubusercontent.com/5795126/34287793-bf4736d6-e6e9-11e7-9a27-fa0f6741ac3d.png)

> Server app window display all orders in flow layout panel, blue sky color represent local customers and green one represent drive through clients which have higher priority.

![zrzut ekranu 2017-12-29 o 09 46 12](https://user-images.githubusercontent.com/5795126/34433112-2effc48c-ec7d-11e7-9080-85d176ef89c0.png)



## Code Samples
### Client side.

> Change window content code snipit:

``` C#
private void bntHome_Click(object sender, System.EventArgs e)
{
    SidePanel.Location = bntHome.Location;
    honeUserControl1.BringToFront();
}
 ```
 
 > Increment amount of product:

``` C#
private void bntUp_Click(object sender, System.EventArgs e)
{
    var number = int.Parse(this.AmountLabel.Text);
    number++;
    this.AmountLabel.Text = number.ToString();
}
 ```
 
###  Server side.
 
 > Convert Json to object:
 ``` C#
 public static Order FromJson(string json) => JsonConvert.DeserializeObject<Order>(json, Converter.Settings);
 ```
 
 > Starting up server and begin accept callback asynchronously:
 
 ``` C#
 private static Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
 
 _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 100));
 _serverSocket.Listen(10);
 _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
```

> Before exiting application, save all orders to json file:
 
 ``` C#
 Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
 ```
 ``` C#
 private static void Application_ApplicationExit(object sender, EventArgs e)
 {
    var date = DateTime.UtcNow.ToString(@"MM_dd_yyyy");
    try
    {
        File.WriteAllText(string.Format("C:\\Users\\marci\\Documents\\Project\\All_Saves\\{0}.json", date),JsonConvert.SerializeObject(Form1.ListOfOrders));
    }
    catch (Exception ex)
    {
        File.WriteAllText(string.Format("C:\\Users\\marci\\Documents\\Project\\All_Saves\\Logs\\Log_{0}", date), ex.ToString());
    }
 }
```

## Installation

> Not ready yet.

## Testing

> Not ready yet.
>Will be added in the nearest future.

## Todo
> Manager Panel
App should fetch json from all_saves and present summary daily report.
