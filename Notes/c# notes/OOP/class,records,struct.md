<table border="1" cellspacing="0" cellpadding="8" style="border-collapse: collapse; text-align: left; font-family: monospace; width: 100%;">
    <thead style="background-color: #f2f2f2;">
      <tr>
        <th>🔰 Feature</th>
        <th>🧱 Class</th>
        <th>🧩 Struct</th>
        <th>📦 Record</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>📌 Type Category</td>
        <td>📌 Reference Type<br>└─ Stores reference to object on the heap.</td>
        <td>📌 Value Type<br>└─ Stores actual data directly.</td>
        <td>📌 Reference Type (or Value with <code>record struct</code>)<br>└─ Default is reference type.</td>
      </tr>
      <tr>
        <td>📦 Memory Location</td>
        <td>📦 Stored on Heap<br>└─ Managed by garbage collector.</td>
        <td>🧮 Stored on Stack<br>└─ Fast access; no GC overhead.</td>
        <td>📦 Stored on Heap (or Stack if <code>record struct</code>).</td>
      </tr>
      <tr>
        <td>🔄 Mutability</td>
        <td>🔄 Mutable by Default<br>└─ Fields/properties are freely changeable.</td>
        <td>🔄 Mutable by Default<br>└─ Can mutate unless marked readonly.</td>
        <td>🔒 Immutable by Default<br>└─ Uses <code>init;</code> for properties; mutation via <code>with</code>.</td>
      </tr>
      <tr>
        <td>🧬 Inheritance</td>
        <td>🧬 Supports Inheritance<br>└─ Can derive and override.</td>
        <td>🚫 No Inheritance<br>└─ Can only implement interfaces.</td>
        <td>🧬 Supports Inheritance<br>└─ Inherits from other records.</td>
      </tr>
      <tr>
        <td>⚖️ Equality</td>
        <td>🔁 Uses Reference Equality<br>└─ Compares memory location.</td>
        <td>⚖️ Uses Value Equality<br>└─ Compares field values.</td>
        <td>⚖️ Uses Value Equality<br>└─ Compares property values.</td>
      </tr>
      <tr>
        <td>🎯 Ideal Use Case</td>
        <td>🤖 Behavior-Rich Models<br>└─ Entities with logic/methods.</td>
        <td>🪶 Lightweight Data Types<br>└─ Small structs like <code>Point</code>, etc.</td>
        <td>🧾 Immutable Data Models<br>└─ DTOs, configs, result models.</td>
      </tr>
      <tr>
        <td>🧠 Programming Model Fit</td>
        <td>🧠 Good for OOP and Abstractions<br>└─ Use when modeling real-world entities.</td>
        <td>⚙️ High Performance<br>└─ Use when performance is key.</td>
        <td>🧠 Functional/Immutable Scenarios<br>└─ Enables safe data modeling.</td>
      </tr>
      <tr>
        <td>🔍 Equality Customization</td>
        <td>🧰 Default Equality Not Overridden<br>└─ Need to override manually.</td>
        <td>🔁 Can Override Equals/HashCode<br>└─ Value-based comparison possible.</td>
        <td>🎯 Auto-Generated Equality Logic<br>└─ Built-in override of equality.</td>
      </tr>
    </tbody>
  </table>
  