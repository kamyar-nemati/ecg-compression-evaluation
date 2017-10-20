# Repository name: ecg-compression-evaluation
A Graphical User Interface (GUI) application to evaluate ECG signal data compression performance and measure signal distortion.

## Repo Description
The application is written under Windows Presentation Foundation (WPF) subsystem to provide the main UI window and it uses Windows Forms to draw line charts. This is meant to be a convenient tool to accurately examine and demonstrate the performace of the proposed hybrid ECG data compression technique in repo _libecg_ for scientific research purposes.

## Dependency
This application depends: __libecg_clr_interface__ [](Here) <https://github.com/kamyar-nemati/libecg-clr-interface>

The core compression library is __libecg__ which is written in native C++ 14. Therefore, in order to utilize unmanaged code in DotNET framework, a wrapper is necessary. The _libecg_clr_interface_ is the wrapper.

## Screenshots
### Main window
The ECG signal dataset file is selected. Threshold and aperture values are set. The dataset is compressed and then decompressed.

![Main window](https://user-images.githubusercontent.com/29518086/29880974-d9045480-8ddb-11e7-9060-ff3db93327a6.PNG "Main window")

### Plot
At this point, the original signal, reconstructed signal, and the overlapping of both is viewable.

![Plot](https://user-images.githubusercontent.com/29518086/29881025-fd03467a-8ddb-11e7-8b6c-04dc91ef68c2.PNG "Plot")

### Plot (Zoom)
The plot window can zoom in to provide better view on signals.

ZoomIn: <kbd> + </kbd>

ZoomOut: <kbd> - </kbd>

![plot-window-zoom-screenshot](https://user-images.githubusercontent.com/29518086/29881061-161c3324-8ddc-11e7-8027-373fd7ef2f4c.png)
