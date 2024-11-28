<h1>🏗️ Clean Architecture Demo</h1>
  <p>This repository demonstrates a <b>Clean Architecture</b> implementation using the <b>CQRS Pattern</b>, <b>MediatR Pattern</b>, and <b>AutoMapper</b>. The project showcases a modular and scalable solution for modern application development.</p>

  <hr>

  <h2>📂 Project Structure</h2>
  <h3>1. Domain Layer</h3>
  <ul>
    <li>Core business logic and domain models.</li>
    <li>Contains entities, value objects, and domain services.</li>
  </ul>

  <h3>2. Application Layer</h3>
  <ul>
    <li>Implements <b>CQRS (Command-Query Responsibility Segregation)</b> for separating read and write operations.</li>
    <li>Handles business rules and use cases.</li>
    <li>Integrates with <b>MediatR</b> for reducing dependencies.</li>
  </ul>

  <h3>3. Infrastructure Layer</h3>
  <ul>
    <li>Manages external concerns such as database access, third-party services, and file systems.</li>
    <li>Contains data access implementations (e.g., EF Core).</li>
  </ul>

  <h3>4. Presentation Layer</h3>
  <ul>
    <li>The entry point for user interaction (e.g., Web API, UI).</li>
    <li>Interfaces directly with the <b>Application Layer</b>.</li>
  </ul>

  <hr>

  <h2>✨ Key Features</h2>
  <h3>CQRS Pattern</h3>
  <ul>
    <li>Separation of <b>Command</b> and <b>Query</b> responsibilities for better scalability and maintainability.</li>
    <li>Commands perform state-changing actions, while Queries retrieve data without altering the state.</li>
  </ul>

  <h3>MediatR Pattern</h3>
  <ul>
    <li>A mediator-based approach for implementing <b>request-response</b> pipelines.</li>
    <li>Simplifies communication between application components.</li>
  </ul>

  <h3>AutoMapper</h3>
  <ul>
    <li>Object-object mapping for seamless transformation between DTOs and domain models.</li>
  </ul>

  <hr>

  <h2>⚙️ Setup</h2>
  <ol>
    <li>Clone the repository:
      <pre><code>git clone https://github.com/your-username/your-repo.git
cd your-repo
      </code></pre>
    </li>
    <li>Install dependencies:
      <pre><code>dotnet restore</code></pre>
    </li>
    <li>Run the application:
      <pre><code>dotnet run</code></pre>
    </li>
  </ol>

  <hr>

  <h2>🛠️ Technologies Used</h2>
  <ul>
    <li><b>.NET 8</b></li>
    <li><b>Entity Framework Core</b></li>
    <li><b>MediatR</b></li>
    <li><b>AutoMapper</b></li>
    <li><b>CQRS Pattern</b></li>

  </ul>
  
 <h2>📖 References</h2>
<ul>
  <li><a href="https://www.amazon.com/Clean-Architecture-Craftsmans-Software-Structure/dp/0134494164" target="_blank">Clean Architecture Principles</a></li>
  <li><a href="https://martinfowler.com/bliki/CQRS.html" target="_blank">CQRS Design Pattern</a></li>
  <li><a href="https://github.com/jbogard/MediatR" target="_blank">MediatR Documentation</a></li>
  <li><a href="https://docs.automapper.org/en/stable/" target="_blank">AutoMapper Documentation</a></li>
</ul>
  <hr>

  <h2>📜 License</h2>
  <p>This project is licensed under the <a href="LICENSE">MIT License</a>.</p>
