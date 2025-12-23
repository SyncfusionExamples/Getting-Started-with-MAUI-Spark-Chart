# Getting Started with the .NET MAUI Toolkit Spark Chart

This sample demonstrates how to get started with the .NET MAUI Toolkit Spark Chart control in a .NET MAUI application.

## Sample

```xaml
    <Grid RowDefinitions="20*,80*" Margin="20">

        <Label Grid.Row="0" Text="Stock Price Trend" HorizontalTextAlignment="Center"
                FontSize="18" FontAttributes="Bold"/>

        <sparkchart:SfSparkColumnChart Grid.Row="1" ItemsSource="{Binding Data}" 
                                        YBindingPath="Value" Padding="20" 
                                        FirstPointFill="YellowGreen"
                                        LastPointFill="BlueViolet"
                                        HighPointFill="DeepPink"
                                        LowPointFill="Salmon"
                                        NegativePointsFill="ForestGreen">
        </sparkchart:SfSparkColumnChart>

    </Grid>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
