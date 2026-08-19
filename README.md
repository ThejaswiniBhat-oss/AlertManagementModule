# Alert Management Module

A lightweight desktop alert management application built with **C# and WPF**. The application demonstrates alert creation, priority classification, collection management, and a simple interactive desktop interface.

## Overview

The application provides a simple interface for viewing and managing system-style alerts. Alerts are categorized by priority and displayed in a list, with support for adding test alerts and clearing the alert list.

The application maintains a maximum capacity of **7 alerts**. When a new alert is added beyond the capacity, the oldest alert is automatically removed.

## Technologies

* **C#**
* **.NET 10**
* **WPF (Windows Presentation Foundation)**
* **XAML**

## Features

* Display alerts in an interactive WPF interface
* Categorize alerts as **High**, **Medium**, or **Low** priority
* Add test alerts based on priority
* Maintain a maximum of 7 alerts
* Automatically remove the oldest alert when capacity is exceeded
* Clear all alerts with a single action
* Pre-populated demo alerts for testing

## Application Structure

### `Alert`

Represents an individual alert with:

* Alert message
* Alert priority

### `AlertPriority`

Defines the available priority levels:

* High
* Medium
* Low

### `AlertManager`

Responsible for managing the alert collection.

Key responsibilities include:

* Maintaining the alert list
* Adding new alerts
* Enforcing the maximum alert capacity
* Seeding demo alerts
* Clearing all alerts

### `AlertsWindow`

Provides the WPF user interface for interacting with the alert manager.

The interface includes:

* Alert list
* Priority display
* Test buttons for adding alerts
* Clear All functionality

## Getting Started

### Prerequisites

* Windows
* .NET 10 SDK
* Visual Studio 2022 or later with WPF/.NET desktop development support

### Running the Application

1. Clone the repository.
2. Open the solution/project in Visual Studio.
3. Build the project.
4. Run the application.

The application will launch with a set of demo alerts already populated.

## Example Alerts

The demo data includes system-style alerts such as:

* Server CPU usage above a threshold
* Database replication issues
* Service availability issues
* Disk usage warnings
* API latency warnings
* Software update notifications
* Scheduled maintenance reminders

## Project Purpose

This project demonstrates fundamental concepts in **C# application development and WPF**, including:

* Object-oriented programming
* Enumerations and classes
* Observable collections
* Data Binding
* Event-driven UI interactions
* XAML-based interface design
* Basic application state management

