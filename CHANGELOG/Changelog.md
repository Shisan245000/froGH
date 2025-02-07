# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/).

## [Unreleased]
---
## [2.2.8]
### Added
- _**Get Euler Angles ZYZ**_ and _**Get Euler Angles ZYX**_ components: they compute Euler angles for the rotation part of an affine rigid Transformation in the ZYZ and ZYX format respectively. ZYX Euler angles are also known as Yaw, Pitch and Roll.
- _**Rotation from ZYZ Euler Angles**_ and _**Rotation from ZYX Euler Angles**_ components perform the inverse operation, computing a Rotation Transformation from Euler angles

### Changed

### Deprecated

### Removed

### Fixed

## [2.2.7]
### Added

### Changed
- _**Camera Report**_ can report data for Named Views or the current active view; update values for active view can be done with external toggle or by double-clicking the component
- _**Slider Value display**_ by default Slider channels have hidden wires; some internal spacing parameters adjusted

### Deprecated

### Removed

### Fixed


## [2.2.6]
### Added
- _**Froggle**_: a special kind of toggle that flips status upon double-click or whenever an input that can be cast as True is detected on change or solution. Any False value will not change its status. In practice, you can attach a button and the Froggle will flip status at every button push, or attach a counter and have it flip status, or get creative (for example: try attaching a panel containing '1' and connect a trigger to the panel to have time-driven boolean alternates). By design, it also resets to False each time a file that contains this component is reopened.
- _**Space-Filling Polyhedra Generator**_: added 2 more space-filling polyhedra: Elongated Dodecahedron and Gyrobifastigium.

### Changed
- _**SaveGHFile**_ now outputs a boolean value upon successful save
- _**GHFilePathInfo**_ can be updated with a double-click
- _**Slider Value display**_ now uses a variable zoomable interface to manage sliders input - see example file for details

### Deprecated

### Removed

### Fixed
- Fixed a small bug in _**DirectoryReader**_ to adjust input paths that do not end with a '\\' character - this affected output Files and Directories lists.

## [2.2.5]
### Added

### Changed
- _**ZoomToObject**_ now can also Zoom in; it's actually a new version of the component, old one is marked obsolete
- Changelog format updated

### Deprecated

### Removed

### Fixed

## [2.2.4]
### Added

### Changed

### Deprecated

### Removed

### Fixed
- corrected a bug in the  _**Space Filling Polyhedra Generator**_ component that generated inconsistent polyline directions for face contours

## [2.2.3]
### Added
- added _**Data Tree Graph**_ component
### Changed

### Deprecated

### Removed

### Fixed


## [2.2.2]
### Added
- added _**L-Plolyline from Plane**_ component
### Changed
- changed Save String to File behavior (removed empty line at end of file)
### Deprecated

### Removed

### Fixed

## [2.2.1]
### Added

### Changed
- Mesh topology components outputs now sorted by edge sequence
### Deprecated

### Removed

### Fixed