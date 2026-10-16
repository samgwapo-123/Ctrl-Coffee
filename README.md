# ☕ Byte & Brew — Coffee • Tech • Repair

> **CSIT321 Midterm Practical Lab Exam**  
> A modern, responsive web application combining an artisan café, gadget shop, and device repair lab into a unified digital storefront. Built with **C#**, **Blazor (.NET 8)**, and **Tailwind CSS**.

---

## 📖 Overview

**Byte & Brew** merges the cozy atmosphere of a specialty coffee shop with a practical device repair and gadget shop. Customers can explore drink and pastry menus, order charging cables and tech essentials, book an on-site device repair appointment, and review orders through an interactive cart.

---

## 🚀 Key Features

### ☕ 1. Café & Pastry Storefront (`/cafe`)
- Curated selection of handcrafted coffees, cold brews, and fresh pastries.
- Filterable product display with prices in Philippine Pesos (₱).
- Resilient image system: automatically loads product photography with an instant typographic emoji fallback if assets are missing.

### 🎧 2. Gadget & Tech Shop (`/gadgets`)
- Browse everyday mobile accessories, fast chargers, earbuds, and wearables.
- Real-time client-side search/filtering bar.
- Interactive favorite/like toggle on every product card.

### 🔧 3. Repair Studio Booking (`/repair`)
- Book hardware maintenance and repair appointments for phones, laptops, and gadgets.
- Form validation ensuring valid client contact information, chosen device type, date, and time slot.
- Booking confirmation integrates into the shopping cart to coordinate pickup time with café orders.

### 🛒 4. Dynamic Cart & Checkout (`/cart`)
- Centralized cart service maintaining state across navigation.
- Real-time line-item quantity controls (increase, decrease, remove).
- Sticky order summary displaying live total amounts.
- Validated checkout form with order confirmation modal/screen.

### 🎨 5. Responsive Design & Tailwind Animations
- Custom-built warm café/tech theme using modern CSS variables (`ink`, `cream`, `forest`, `copper`).
- Subtle micro-interactions: cart badge pop effect, staggered product card fade-up, and floating hero elements.
- Fully accessible with `aria-*` tags and reduced-motion fallbacks.

---

## 🛠️ Tech Stack

- **Framework:** ASP.NET Core Blazor (.NET 8.0)
- **Language:** C# 12
- **Styling:** Tailwind CSS (Modern CLI build pipeline)
- **State Management:** In-memory Scoped Services (`CartService`, `BookingService`)
- **Validation:** DataAnnotations Validator (`EditForm`, `InputText`, `ValidationMessage`)

---

## 📁 Project Structure

```text
Midterms_exam/
└── ExamApp/
    ├── Components/
    │   ├── Layout/
    │   │   └── MainLayout.razor       # Navigation bar, cart badge, sticky footer
    │   ├── Pages/
    │   │   ├── Home.razor             # Landing hero, featured items & highlights
    │   │   ├── CafePage.razor         # Food & beverage catalog
    │   │   ├── GadgetsPage.razor      # Tech accessories & search
    │   │   ├── RepairPage.razor       # Appointment booking form
    │   │   └── CartPage.razor         # Line-item adjustments & checkout
    │   ├── App.razor                  # Root component & HTML base tags
    │   ├── PageHeader.razor           # Reusable branded section banner
    │   ├── ProductCard.razor          # Reusable item card with fallback handling
    │   └── Routes.razor               # Client-side router configuration
    ├── Models/
    │   ├── Product.cs                 # Base product model & derived classes (Drink, Pastry, Gadget)
    │   ├── ProductData.cs             # In-memory product seed data
    │   ├── CartItem.cs                # Cart line-item model
    │   ├── CheckoutModel.cs           # Checkout input validation model
    │   ├── RepairBooking.cs           # Appointment booking model
    │   └── RepairService.cs           # Repair catalog model
    ├── Services/
    │   ├── CartServices.cs            # Cart business logic (Add, Remove, Totals)
    │   └── BookingService.cs          # Active repair reservation state
    ├── Styles/
    │   └── input.css                  # Custom Tailwind tokens, components & keyframes
    ├── wwwroot/
    │   ├── images/
    │   │   ├── products/              # Product image assets (.png, .jpg)
    │   │   ├── hero.png               # Home page hero photography
    │   │   ├── banner.png             # Promotional banner
    │   │   └── repair-hero.png        # Repair page banner
    │   └── tailwind.css               # Compiled output CSS
    └── Program.cs                     # Service registrations & middleware pipeline

⚙️ Setup & Running Locally

Prerequisites

  - .NET 8.0 SDK or higher
  - Node.js (v18+ recommended)

1. Clone & Navigate

git clone <repository-url>
cd Midterms_exam/ExamApp

2. Install Tailwind Dependencies

npm install

3. Build Tailwind CSS

To compile the stylesheet:

npm run build

(Or keep the Tailwind watcher running during development):

npm run watch

4. Run the Blazor App

In a separate terminal window, start the .NET development server:

dotnet watch

Open your browser and navigate to the local URL displayed in the terminal
(typically http://localhost:5000 or https://localhost:7001).

🧪 Evaluation Highlights (Rubric Compliance)

1.  Component-Driven Architecture: UI elements (ProductCard, PageHeader,
    MainLayout) are modular, reusable, and cleanly separated.
2.  Object-Oriented Design: The Product model utilizes abstract inheritance
    (Drink, Pastry, Gadget) to cleanly encapsulate category behaviors and image
    resolution logic.
3.  Graceful Asset Degradation: Product cards and headers use inline JavaScript
    onerror fallbacks to ensure that missing or slow-loading images never
    disrupt the visual layout.
4.  Resilient Local Workflow: The application does not rely on third-party cloud
    databases or external APIs, ensuring 100% offline functionality in
    restricted lab exam environments.
